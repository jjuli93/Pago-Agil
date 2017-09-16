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

    }
}
