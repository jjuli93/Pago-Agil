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

namespace PagoAgilFrba.Login
{
    public partial class FrmSeleccionFuncionalidad : Form
    {
        ControlHelper ctrl_helper = Singleton<ControlHelper>.Instance;
        RolDAO rolDao = Singleton<RolDAO>.Instance;
        Rol rol = null;

        public FrmSeleccionFuncionalidad(Rol _rol)
        {
            InitializeComponent();
            rol = _rol;
            this.AcceptButton = seleccionarBtn;
            this.CancelButton = exitBtn;
            inicializar_funcionalidades();

            if (this.Owner == null)
            {
                volverBtn.Enabled = false;
                volverBtn.Visible = false;
            }
        }

        private void inicializar_funcionalidades()
        {
            funcionalidadesLb.Items.Clear();
            //obtener las funcionales desde el dao

            foreach (var f in rol.funcionalidades)
            {
                
            }
        }

        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrl_helper.cerrar_app();
        }

        private void cerrarSesionHl_Click(object sender, EventArgs e)
        {
            ctrl_helper.cerrar_sesion();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
