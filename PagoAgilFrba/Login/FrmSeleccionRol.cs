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
    public partial class FrmSeleccionRol : Form
    {
        Usuario usuario = null;
        ControlHelper ctrl_helper = Singleton<ControlHelper>.Instance;
        Rol rol_seleccionado = null;

        public FrmSeleccionRol(Usuario _user)
        {
            InitializeComponent();
            usuario = _user;
            inicializar_roles();
            continuarBtn.Enabled = false;
            this.AcceptButton = continuarBtn;
            this.CancelButton = salirBtn;
        }

        private void inicializar_roles()
        {
            foreach (var r in usuario.roles)
            {
                if (r.habilitado)
                    this.rolesCb.Items.Add(new ItemControlHelper.itemComboBox(r.Nombre, r.Id));
            }
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            ctrl_helper.cerrar_app();
        }

        private void cerrarSesionHl_Click(object sender, EventArgs e)
        {
            ctrl_helper.cerrar_sesion();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            if (rol_seleccionado != null)
            {
                FrmSeleccionFuncionalidad menuFuncionalidades = new FrmSeleccionFuncionalidad(rol_seleccionado);
                menuFuncionalidades.Show(this);
                this.Hide();
            }
        }

        private void rolesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemControlHelper.itemComboBox rol_cb = rolesCb.SelectedItem as ItemControlHelper.itemComboBox;

            foreach (Rol rol in usuario.roles)
            {
                if ((rol.Id == rol_cb.id_item) && (rol.Nombre.Equals(rol_cb.nombre_item)))
                {
                    rol_seleccionado = rol;
                    break;
                }
            }

            if (rol_seleccionado != null)
            {
                this.continuarBtn.Enabled = true;
            }
        }
    }
}
