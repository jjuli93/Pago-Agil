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
        private Funcionalidad funcionalidadSeleccionada = null;

        public FrmSeleccionFuncionalidad(Rol _rol)
        {
            InitializeComponent();
            rol = _rol;
            this.AcceptButton = seleccionarBtn;
            this.CancelButton = exitBtn;
            inicializar_funcionalidades();
            seleccionarBtn.Enabled = false;
            funcionalidadSeleccionada = null;
        }

        private void FrmSeleccionFuncionalidad_Load(object sender, EventArgs e)
        {
            if (this.Owner == null)
            {
                volverBtn.Enabled = false;
                volverBtn.Visible = false;
            }
        }

        private void inicializar_funcionalidades()
        {
            funcionalidadesLb.Items.Clear();
            rol.funcionalidades = rolDao.get_funcionalidades_by_Rol(rol.Id);
            rol.funcionalidades.ForEach(f => funcionalidadesLb.Items.Add(new ItemControlHelper.itemListBox(f.Nombre, f.Id)));
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
            if (funcionalidadSeleccionada == null)
                return;

            Form frm = funcionalidadSeleccionada.get_form();
            frm.Show(this);
            this.Hide();
        }

        private void funcionalidadesLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (funcionalidadesLb.SelectedItem == null)
                return;

            ItemControlHelper.itemListBox funcSelected = this.funcionalidadesLb.SelectedItem as ItemControlHelper.itemListBox;

            foreach (Funcionalidad item in this.rol.funcionalidades)
            {
                if ((item.Id == funcSelected.id_item) && (item.Nombre.Equals(funcSelected.nombre_item)))
                {
                    funcionalidadSeleccionada = item;
                    break;
                }
            }

            if (funcionalidadSeleccionada != null)
            {
                seleccionarBtn.Enabled = true;
            }
        }

    }
}
