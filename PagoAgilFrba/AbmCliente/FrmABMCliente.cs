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

namespace PagoAgilFrba.AbmCliente
{
    public partial class FrmABMCliente : Form
    {
        private string default_description = "null";
        private List<Control> label_obligatorios;
        private List<Control> campos_obligatorios;
        private List<Label> campo_labels;
        ControlHelper helper = Singleton<ControlHelper>.Instance;
        int fila_seleccionada = -1;

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
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Modificar Cliente";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
            habilitadoChk.Visible = true;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Eliminar Cliente";
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el buscador de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        #endregion
    }
}
