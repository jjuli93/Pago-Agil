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
using PagoAgilFrba.Negocio;
using PagoAgilFrba.Datos;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class FrmABMSucursal : Form
    {
        private string default_description = "";
        private List<Control> label_obligatorios;
        private List<Control> campos_obligatorios;
        private List<Label> campo_labels;
        ControlHelper helper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        SucursalDAO sucursalDao = new SucursalDAO();
        int fila_seleccionada = -1;

        //string flt_nombre = "";
        //string flt_direccion = "";
        //string flt_cp = "";

        public FrmABMSucursal()
        {
            InitializeComponent();
            habilitadoChk.Visible = false;
            
            label_obligatorios = new List<Control>() { obligatoriosLbl, obligatorio1, obligatorio2, obligatorio3 };
            campos_obligatorios = new List<Control>() { nombreTb, cpTb, direccionTb };

            restablecer_controles();
        }

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
            sucursalesDt.ReadOnly = false;
        }

        private void limpiar_campos()
        {
            nombreTb.Text = string.Empty; 
            direccionTb.Text = string.Empty;
            cpTb.Text = string.Empty;
            habilitadoChk.Checked = false;
            fila_seleccionada = -1;
            helper.limpiar_errorProvider(campos_obligatorios, errorProvider);
        }

        public Sucursal obtener_sucursal_desde_form()
        {
            try
            {
                Sucursal suc = new Sucursal()
                {
                    nombre = nombreTb.Text.Trim(),
                    direccion = direccionTb.Text.Trim(),
                    codPostal = cpTb.Text.Trim(),
                    habilitado = habilitadoChk.Checked
                };

                return suc;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void obtener_sucursal_desde_row()
        {
            try
            {
                DataGridViewRow row = sucursalesDt.CurrentRow;

                //Select s.IdSucursal, s.CodigoPostal, s.Direccion, s.Habilitada, s.Nombre

                nombreTb.Text = row.Cells["Nombre"].Value.ToString();
                direccionTb.Text = row.Cells["Direccion"].Value.ToString();
                cpTb.Text = row.Cells["CodigoPostal"].Value.ToString();
                habilitadoChk.Checked = Convert.ToBoolean(Convert.ToInt32(row.Cells["Habilitada"].Value));
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

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

        #region "Botones ABM"
        private void crearBtn_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Crear Sucursal";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
            sucursalesDt.ReadOnly = true;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada >= 0)
            {
                confirmPnl.Visible = true;
                abmPnl.Visible = false;
                descripcionLbl.Text = "Modificar Sucursal";
                helper.visualizar_controles(label_obligatorios, true);
                habilitar_todo(true);
                habilitadoChk.Visible = true;
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada >= 0)
            {
                confirmPnl.Visible = true;
                abmPnl.Visible = false;
                descripcionLbl.Text = "Eliminar Sucursal";
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            habilitar_todo(true);
            descripcionLbl.Text = "Buscador";
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region "Botones Confirmar"
        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string operacion = descripcionLbl.Text;
            string msg = string.Format("¿Confirmar <{0}>?", operacion);

            helper.limpiar_errorProvider(campos_obligatorios, errorProvider);

            if (MessageBox.Show(msg, "PagoAgil FRBA App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                switch (operacion)
                {
                    case "Crear Sucursal":
                        do_insert();
                        break;
                    case "Modificar Sucursal":
                        do_update();
                        break;
                    case "Eliminar Sucursal":
                        do_delete();
                        break;
                    case "Buscador":
                        do_search();
                        break;
                }
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            restablecer_controles();
            limpiar_campos();
        }
        #endregion

        #region "Operaciones"
        private void do_insert()
        {
            try
            {
                if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
                {
                    sucursalDao.crear_sucursal(obtener_sucursal_desde_form());
                    msgHelper.mostrar_aviso("Se ha creado la sucursal.", "Alta de Sucursal");
                    limpiar_campos();
                    helper.limpiar_tabla(sucursalesDt);
                }
                else
                    msgHelper.mostrar_CamposIncompletos();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Sucursal");
            }
        }

        private void do_update()
        {
            try
            {
                if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
                {
                    Sucursal suc = obtener_sucursal_desde_form();
                    suc.id = Convert.ToInt32(sucursalesDt.CurrentRow.Cells["IdSucursal"].Value);

                    sucursalDao.modificar_sucursal(suc);
                    msgHelper.mostrar_aviso("Se ha modificado la sucursal.", "Modificación de Sucursal");
                    limpiar_campos();
                    restablecer_controles();
                    helper.limpiar_tabla(sucursalesDt);
                }
                else
                    msgHelper.mostrar_CamposIncompletos();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Sucursal");
            }
        }

        private void do_delete()
        {
            try
            {
                int id = Convert.ToInt32(sucursalesDt.CurrentRow.Cells["IdSucursal"].Value);

                sucursalDao.eliminar_sucursal(id);
                msgHelper.mostrar_aviso("Se ha dado de baja a la sucursal.", "Baja de Sucursal");
                limpiar_campos();
                restablecer_controles();
                helper.limpiar_tabla(sucursalesDt);
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Sucursal");
            }
        }

        private void do_search()
        {
            try
            {
                DataTable dt = sucursalDao.buscar_sucursales(nombreTb.Text.Trim(), direccionTb.Text.Trim(), cpTb.Text.Trim());

                if (dt.Rows.Count != 0) 
                {
                    sucursalesDt.DataSource = dt;
                    //flt_nombre = nombreTb.Text.Trim();
                    //flt_direccion = direccionTb.Text.Trim();
                    //flt_cp = cpTb.Text.Trim();
                }
                else
                    msgHelper.mostrar_aviso("No se han encontrado registros", "Buscador de Sucursales");
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Sucursal");
            }
        }
        #endregion

        private void sucursalesDt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                limpiar_campos();
                restablecer_controles();
                this.fila_seleccionada = e.RowIndex;
                obtener_sucursal_desde_row();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Sucursal");
            }
        }

    }
}
