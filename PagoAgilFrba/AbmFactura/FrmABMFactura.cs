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

namespace PagoAgilFrba.AbmFactura
{
    public partial class FrmABMFactura : Form
    {
        List<Control> obligatorios;
        ControlHelper ctrlHelper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        int total = 0;
        string default_description = string.Empty;
        int filaItem_seleccionada = -1;
        int filaFactura_seleccionada = -1;

        public FrmABMFactura()
        {
            InitializeComponent();
            obligatorios = new List<Control>() { clienteTb, empresaCb, vencimientoDtp };
            fillComboEmpresas();
            descripcionLbl.Text = default_description;
        }

        private void fillComboEmpresas()
        {
            
        }

        #region "Exit Buttons"
        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlHelper.cerrar_app();
        }

        private void cerrarSesionHl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlHelper.cerrar_sesion();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Close();
            }
        }
        #endregion

        #region "ToolStrip Buttons"
        private void addToolBtn_Click(object sender, EventArgs e)
        {
            Form frmItem = new FrmItemFactura(false);
            frmItem.ShowDialog(this);
        }

        private void editToolBtn_Click(object sender, EventArgs e)
        {
            if (filaItem_seleccionada >= 0)
            {
                Form frmItem = new FrmItemFactura(true);
                frmItem.ShowDialog(this);
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void deleteToolBtn_Click(object sender, EventArgs e)
        {
            if (filaItem_seleccionada >= 0)
            {
                itemsDgv.Rows.RemoveAt(filaItem_seleccionada);
                filaItem_seleccionada = -1;
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void clearAllToolBtn_Click(object sender, EventArgs e)
        {
            itemsDgv.DataSource = null;
        }
        #endregion

    }
}
