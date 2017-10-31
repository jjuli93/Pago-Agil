using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Helpers;
using PagoAgilFrba.Datos;
using PagoAgilFrba.Negocio;

namespace PagoAgilFrba.AbmCliente
{
    public partial class FrmABMCliente : Form
    {
        private string default_description = string.Empty;
        private List<Control> label_obligatorios;
        private List<Control> campos_obligatorios;
        private List<Label> campo_labels;
        ControlHelper helper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        ClienteDAO clienteDAO = Singleton<ClienteDAO>.Instance;
        int fila_seleccionada = -1;
        int id_cliente = -1;
        bool cliente_habilitado = false;

        public FrmABMCliente()
        {
            InitializeComponent();
            descripcionLbl.Text = default_description;
            label_obligatorios = new List<Control>() { obligatoriosLbl, obligatorio1, obligatorio2, obligatorio3, obligatorio4, obligatorio5, obligatorio6, obligatorio7, obligatorio8 };
            campos_obligatorios = new List<Control>() { nombreTb, apellidoTb, dniTb, fecnacDtp, direccionTb, codpostTb, emailTb, telefonoTb };
            campo_labels = new List<Label>() { nombreLb, apellidoLb, dniLb, fecnacLb, dirLb, cpLb, emailLb, telLb };
            helper.visualizar_controles(label_obligatorios, false);
            habilitar_todo(false);
            habilitadoChk.Enabled = false;
            habilitadoChk.Visible = false;
            clientesDt.ClearSelection();
            clientesDt.CurrentCell = null;
        }

        #region "Botones de salida"
        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helper.cerrar_app();
        }

        private void cerrarSesionHl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helper.cerrar_sesion();
        }
        #endregion
        
        #region "Botones - Tab Principal"
        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Crear Cliente";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
            limpiar_campos();
            frmTabCtrl.SelectedTab = principalPage;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada >= 0)
            {
                confirmPnl.Visible = true;
                abmPnl.Visible = false;
                descripcionLbl.Text = "Modificar Cliente";
                helper.visualizar_controles(label_obligatorios, true);
                habilitar_todo(true);
                habilitadoChk.Visible = true;
                frmTabCtrl.SelectedTab = principalPage;
            }
            else
            {
                msgHelper.mostrar_FilaNoSeleccionada();
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada >= 0)
            {
                confirmPnl.Visible = true;
                abmPnl.Visible = false;
                descripcionLbl.Text = "Eliminar Cliente";
                frmTabCtrl.SelectedTab = principalPage;
            }
            else
            {
                msgHelper.mostrar_FilaNoSeleccionada();
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string operacion = descripcionLbl.Text;
            string msg = string.Format("¿Confirmar <{0}>?", operacion);

            if (MessageBox.Show(msg, "PagoAgil FRBA App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                helper.limpiar_errorProvider(campos_obligatorios, errorProvider);

                switch (operacion)
                {
                    case "Crear Cliente":
                        do_insert();
                        break;
                    case "Modificar Cliente":
                        do_update();
                        break;
                    case "Eliminar Cliente":
                        do_delete();
                        break;
                }
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            restablecer_controles();
        }
        #endregion

        #region "ALTA-BAJA-MODIFICACIONES"
        private void do_insert()
        {
            if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
            {
                try
                {
                    if (clienteDAO.crear_cliente(obtener_cliente_desde_form()))
                    {
                        msgHelper.mostrar_aviso("Alta de cliente exitosa.", "Nuevo Cliente");
                        this.limpiar_campos();
                    }
                    else
                    {
                        msgHelper.mostrar_error("No se ha podido crear el nuevo cliente.", "Error en ABM Clientes");
                    }
                }
                catch (Exception ex)
                {
                    msgHelper.mostrar_error(ex.Message, "Error en ABM Clientes");
                }
            }
            else
                msgHelper.mostrar_CamposIncompletos();
        }

        private void do_update()
        {
            if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
            {
                try
                {
                    if (clienteDAO.modificar_cliente(obtener_cliente_desde_form()))
                    {
                        msgHelper.mostrar_aviso("Modificación de cliente exitosa.", "Modificación Cliente");
                        limpiar_campos();
                        restablecer_controles();
                        this.limpiarBtn_Click(null, null);
                    }
                    else
                    {
                        msgHelper.mostrar_error("No se ha podido modificar el cliente seleccionado.", "Error en ABM Clientes");
                    }
                }
                catch (Exception ex)
                {
                    msgHelper.mostrar_error(ex.Message, "Error en ABM Clientes");
                }

                this.restablecer_controles();
            }
            else
                msgHelper.mostrar_CamposIncompletos();
        }

        private void do_delete()
        {
            try
            {
                if (id_cliente > 0)
                {
                    if (clienteDAO.eliminar_cliente(id_cliente))
                    {
                        msgHelper.mostrar_aviso("Baja de cliente exitosa.", "Baja de Cliente");
                        limpiar_campos();
                        restablecer_controles();
                        this.limpiarBtn_Click(null, null);
                    }
                    else
                    {
                        msgHelper.mostrar_error("No se ha podido modificar el cliente seleccionado.", "Error en ABM Clientes");
                    }
                }
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Clientes");
            }
        }
        #endregion

        #region "Commons"
        public void habilitar_todo(bool valor_hab)
        {
            helper.habilitar_controles(campos_obligatorios, valor_hab);
            habilitadoChk.Enabled = valor_hab;
        }

        private void restablecer_controles()
        {
            confirmPnl.Visible = false;
            abmPnl.Visible = true;
            descripcionLbl.Text = default_description;
            helper.visualizar_controles(label_obligatorios, false);
            habilitar_todo(false);
            habilitadoChk.Visible = false;
            helper.limpiar_errorProvider(campos_obligatorios, errorProvider);
        }

        private void limpiar_campos()
        {
            nombreTb.Text = string.Empty;
            apellidoTb.Text = string.Empty;
            dniTb.Text = string.Empty;
            direccionTb.Text = string.Empty;
            telefonoTb.Text = string.Empty;
            codpostTb.Text = string.Empty;
            emailTb.Text = string.Empty;
            fecnacDtp.Text = string.Empty;
            fila_seleccionada = -1;
            id_cliente = -1;
            helper.limpiar_errorProvider(campos_obligatorios, errorProvider);
        }

        private Cliente obtener_cliente_desde_form()
        {
            Cliente cliente = new Cliente()
            {
                id = this.id_cliente,
                habilitado = this.cliente_habilitado,
                nombre = nombreTb.Text,
                apellido = apellidoTb.Text,
                dni = Convert.ToUInt32(dniTb.Text),
                mail = emailTb.Text,
                telefono = Convert.ToUInt32(telefonoTb.Text),
                direccion = direccionTb.Text,
                codigoPostal = Convert.ToInt32(codpostTb.Text),
                fecha_nacimiento = Convert.ToDateTime(fecnacDtp.Value)
            };

            return cliente;
        }

        private void cargar_cliente_desde_grilla()
        {
            if (fila_seleccionada < 0)
                return;

            DataGridViewRow fila = clientesDt.Rows[fila_seleccionada];
            
            this.id_cliente = Convert.ToInt32(fila.Cells["ID"].Value);

            if (fila.Cells["Habilitado"].Value.ToString() == "1")
                this.cliente_habilitado = this.habilitadoChk.Checked = true;
            else
                this.cliente_habilitado = this.habilitadoChk.Checked = false;

            nombreTb.Text = fila.Cells["Nombre"].Value.ToString();
            apellidoTb.Text = fila.Cells["Apellido"].Value.ToString();
            dniTb.Text = fila.Cells["DNI"].Value.ToString();
            emailTb.Text = fila.Cells["Mail"].Value.ToString();
            telefonoTb.Text = fila.Cells["Telefono"].Value.ToString();
            direccionTb.Text = fila.Cells["Direccion"].Value.ToString();
            codpostTb.Text = fila.Cells["Codigo_Postal"].Value.ToString();
            fecnacDtp.Value = Convert.ToDateTime(fila.Cells["Fecha_Nacimiento"].Value);
        }
        #endregion

        #region "Controles Tab Buscador"
        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            fltNombre.Text = string.Empty;
            fltApellido.Text = string.Empty;
            fltDNI.Text = string.Empty;

            helper.limpiar_tabla(clientesDt);
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = clienteDAO.buscar_clientes(fltNombre.Text.Trim(), fltApellido.Text.Trim(), fltDNI.Text.Trim(), "");

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No se han encontrado registros", "Buscador de Clientes");
                else
                    clientesDt.DataSource = dt;
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en el buscador de clientes");
            }
        }
        #endregion

        private void clientesDt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                limpiar_campos();
                restablecer_controles();
                this.fila_seleccionada = e.RowIndex;
                cargar_cliente_desde_grilla();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Cliente");
            }
            
        }

        private void telefonoTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            helper.onlyIntNumbers_event(sender, e);
        }

        private void codpostTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            helper.onlyIntNumbers_event(sender, e);
        }

        private void dniTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            helper.onlyIntNumbers_event(sender, e);
        }
    }
}
