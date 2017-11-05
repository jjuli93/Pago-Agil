using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Negocio;
using PagoAgilFrba.Datos;
using PagoAgilFrba.Helpers;

namespace PagoAgilFrba.DevolucionFacturas
{
    public partial class frmDevolucionFacturas2 : Form
    {
        Cliente cliente = null;
        FrmDevolucionFacturas frmParent = null;
        ControlHelper ctrlHelper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;

        public frmDevolucionFacturas2(FrmDevolucionFacturas _frmParent, Cliente _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
            frmParent = _frmParent;
            clienteLb.Text += cliente.nombre + " " + cliente.apellido;
        }

        #region "Botones de salida"
        private void volverBtn_Click(object sender, EventArgs e)
        {
            frmParent.Show();
            this.Close();
        }

        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlHelper.cerrar_app();
        }

        private void cerrarSesionHl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlHelper.cerrar_sesion();
        }
        #endregion

        private void devolverBtn_Click(object sender, EventArgs e)
        {

        }

        private void facturasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
