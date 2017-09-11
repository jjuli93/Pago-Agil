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
        ControlHelper helper = Singleton<ControlHelper>.Instance;

        public FrmABMRol()
        {
            InitializeComponent();
            descripcionLbl.Text = default_description;
            label_obligatorios = new List<Control>() { obligatoriosLbl, obligatorio1, obligatorio2 };
            campos_obligatorios = new List<Control>() { nombreTb, funcionalidadesLb };
            helper.visualizar_controles(label_obligatorios, false);
            helper.habilitar_controles(campos_obligatorios, false);
            habilitadoChk.Visible = false;
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Crear Rol";
            helper.visualizar_controles(label_obligatorios, true);
            helper.habilitar_controles(campos_obligatorios, true);
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Modificar Rol";
            helper.visualizar_controles(label_obligatorios, true);
            helper.habilitar_controles(campos_obligatorios, true);
            habilitadoChk.Visible = true;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Eliminar Rol";
        }

        private void restablecer_controles() 
        {
            confirmPnl.Visible = false;
            abmPnl.Visible = true;
            descripcionLbl.Text = default_description;
            helper.visualizar_controles(label_obligatorios, false);
            helper.habilitar_controles(campos_obligatorios, false);
            habilitadoChk.Visible = false;
            helper.limpiar_errorProvider(campos_obligatorios, errorProvider);
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.restablecer_controles();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
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

    }
}
