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
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Modificar Cliente";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
            habilitadoChk.Visible = true;
            frmTabCtrl.SelectedTab = principalPage;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Eliminar Cliente";
            frmTabCtrl.SelectedTab = principalPage;
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string operacion = descripcionLbl.Text;
            string msg = string.Format("¿Confirmar <{0}>?", operacion);

            if (MessageBox.Show("¿Confirmar Operación?", "PagoAgil FRBA App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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
            this.restablecer_controles();
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
                        MessageBox.Show("Alta de cliente exitosa.", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido crear el nuevo cliente.", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.restablecer_controles();
            }
            else
                MessageBox.Show("Por favor ingrese todos los datos obligatorios", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void do_update()
        {
            if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
            {
                try
                {
                    if (clienteDAO.modificar_cliente(obtener_cliente_desde_form()))
                    {
                        MessageBox.Show("Modificación de cliente exitosa.", "Modificación Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido guardar los cambios realizados.", "Modificación Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.restablecer_controles();
            }
            else
                MessageBox.Show("Por favor ingrese todos los datos obligatorios", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void do_delete()
        {
            try
            {
                if (id_cliente > 0)
                {
                    if (clienteDAO.eliminar_cliente(id_cliente))
                    {
                        MessageBox.Show("Baja de cliente exitosa.", "Baja de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido eliminar el cliente seleccionado.", "Baja de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Commons"
        public void habilitar_todo(bool valor_hab)
        {
            helper.habilitar_controles(campos_obligatorios, valor_hab);
            habilitadoChk.Enabled = valor_hab;

            if (valor_hab)
                helper.cambiar_color_labels(campo_labels, Color.Black);
            else
                helper.cambiar_color_labels(campo_labels, Color.DarkGray);
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
            //emailTb.Text = fila.Cells["Email"].Value.ToString();
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
                var dt = clienteDAO.buscar_clientes(fltNombre.Text, fltApellido.Text, fltDNI.Text, "");

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No se han encontrado registros", "Buscador de Clientes");
                else
                    clientesDt.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el buscador de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion

        private void clientesDt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            this.fila_seleccionada = e.RowIndex;
            cargar_cliente_desde_grilla();
        }
    }
}
