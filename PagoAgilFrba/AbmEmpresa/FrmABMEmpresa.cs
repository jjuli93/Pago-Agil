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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class FrmABMEmpresa : Form
    {
        private string default_description = "null";
        private List<Control> label_obligatorios;
        private List<Control> campos_obligatorios;
        private List<Label> campo_labels;
        ControlHelper helper = Singleton<ControlHelper>.Instance;
        int fila_seleccionada = -1;

        public FrmABMEmpresa()
        {
            InitializeComponent();
            descripcionLbl.Text = default_description;
            label_obligatorios = new List<Control>() { obligatoriosLbl, obligatorio1, obligatorio2, obligatorio3, obligatorio4 };
            campos_obligatorios = new List<Control>() { nombreTb, cuitTb, direccionTb, rubroCb };
            campo_labels = new List<Label>() { nombreLb, cuitLb, dirLb, rubroLb };
            helper.visualizar_controles(label_obligatorios, false);
            habilitar_todo(false);
            habilitadoChk.Visible = false;
        }

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
            empresasDt.ReadOnly = false;
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
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Crear Empresa";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
            empresasDt.ReadOnly = true;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Modificar Empresa";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
            habilitadoChk.Visible = true;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Eliminar Empresa";
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            habilitar_todo(true);
            direccionTb.Enabled = false;
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

        #region "Botones confirmar"
        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string operacion = descripcionLbl.Text;
            string msg = string.Format("¿Confirmar <{0}>?", operacion);

            if (MessageBox.Show("¿Confirmar Operación?", "PagoAgil FRBA App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                switch (operacion)
                {
                    case "Crear Empresa":
                        do_insert();
                        break;
                    case "Modificar Empresa":
                        do_update();
                        break;
                    case "Eliminar Empresa":
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
        }
        #endregion 

        #region "Operaciones"
        private void do_insert()
        {
            throw new NotImplementedException();
        }

        private void do_update()
        {
            throw new NotImplementedException();
        }

        private void do_delete()
        {
            throw new NotImplementedException();
        }

        private void do_search()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
