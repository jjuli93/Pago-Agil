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

namespace PagoAgilFrba.AbmRol
{
    public partial class FrmABMRol : Form
    {
        private string default_description = "null";
        private List<Control> label_obligatorios;
        private List<Control> campos_obligatorios;
        private List<Label> campo_labels;
        ControlHelper helper = Singleton<ControlHelper>.Instance;
        int fila_seleccionada = -1;

        public FrmABMRol()
        {
            InitializeComponent();
            descripcionLbl.Text = default_description;
            label_obligatorios = new List<Control>() { obligatoriosLbl, obligatorio1, obligatorio2 };
            campos_obligatorios = new List<Control>() { nombreTb, fnsChkList };
            campo_labels = new List<Label>() { nombreLb, funcsLb };
            helper.visualizar_controles(label_obligatorios, false);
            habilitar_todo(false);
            habilitadoChk.Visible = false;
        }

        public void habilitar_todo(bool valor_hab)
        {
            helper.habilitar_controles(campos_obligatorios, valor_hab);
            habilitadoChk.Enabled = valor_hab;

            if (valor_hab)
                helper.cambiar_color_labels(campo_labels, Color.Black);
            else
                helper.cambiar_color_labels(campo_labels, Color.DarkGray);
        }

        #region "Botones"
        private void crearBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Crear Rol";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Modificar Rol";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
            habilitadoChk.Visible = true;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Eliminar Rol";
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.restablecer_controles();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string operacion = descripcionLbl.Text;
            string msg = string.Format("¿Confirmar <{0}>?", operacion);

            if (MessageBox.Show("¿Confirmar Operación?", "PagoAgil FRBA App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                switch (operacion)
                {
                    case "Crear Rol":
                        do_insert();
                        break;
                    case "Modificar Rol":
                        do_update();
                        break;
                    case "Eliminar Rol":
                        do_delete();
                        break;
                }
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
        
        #region "ALTA-BAJA-MODIFICACIONES"
        private void do_insert()
        {
            if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
            {
                try
                {
                    //execute
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
                    //execute
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
                //execute
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Commons"
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

        private void obtener_rol_seleccionado()
        {

        }

        private void obtener_fns_seleccionadas()
        {
        }

        private void fnsChkList_EnabledChanged(object sender, EventArgs e)
        {
            if (fnsChkList.Enabled)
                fnsChkList.BackColor = Color.WhiteSmoke;
            else
                fnsChkList.BackColor = Color.LightGray;
        }

        private void limpiar_campos()
        {
            nombreTb.Text = string.Empty;
            fnsChkList.Items.Clear();
            fnsChkList.SelectedIndex = -1;
            fnsChkList.SelectedItem = null;
            fnsChkList.SelectedValue = null;
            fila_seleccionada = -1;
            habilitadoChk.Checked = false;
        }
        #endregion
    }
}
