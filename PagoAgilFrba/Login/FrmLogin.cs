using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Datos;
using PagoAgilFrba.Negocio;
using System.Security.Cryptography;

namespace PagoAgilFrba.Login
{
    public partial class FrmLogin : Form
    {
        LoginDAO loginDao = new LoginDAO();

        public FrmLogin()
        {
            InitializeComponent();
            this.AcceptButton = this.ingresarBtn;
            this.CancelButton = this.cancelarBtn;
            ActiveControl = usernameTB;
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string _username = usernameTB.Text.Trim();
                //Password encriptada con SHA256
                //string _password = passwordToEncript();
                string _password = passwordTB.Text.Trim();

                int resultado_login = loginDao.loguear_usuario(_username, _password);

                switch (resultado_login)
                {
                    case -1: // no existe el user
                        if (MessageBox.Show("El usuario " + _username + " no existe.", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            return;
                        break;
                    case -2: //  pass incorrecta
                        if (MessageBox.Show("Usuario o contraseña incorrectos.", "Error en los datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            return;
                        break;
                    case -3: //  user bloqueado
                        if (MessageBox.Show("El usuario " + _username + " se ha bloqueado.", "Se ha quedado sin intentos de login", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            usernameTB.Text = string.Empty;
                            passwordTB.Text = string.Empty;
                            return;
                        }
                        break;
                    default: //  login correcto
                        ingresar_usuario();
                        break;
                }
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresar_usuario()
        {
            Usuario user = loginDao.get_usuario_logueado();

            if (user == null)
                return;

            int cantidad_roles = user.roles.Count;

            if (cantidad_roles <= 0)
            {
                MessageBox.Show("No se han encontrado roles asignados al usuario", "Ingreso de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Form form = null;

                if (cantidad_roles == 1)
                {
                    form = new FrmSeleccionFuncionalidad(user.roles.First());
                }
                else
                {
                    form = new FrmSeleccionRol(user);
                }

                form.Show();
                this.Hide();
            }
        }

        private string passwordToEncript()
        {
            UTF8Encoding encoderHash = new UTF8Encoding();
            SHA256Managed hasher = new SHA256Managed();
            byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(passwordTB.Text));
            string passEncripted = bytesDeHasheoToString(bytesDeHasheo);

            return passEncripted;
        }

        private string bytesDeHasheoToString(byte[] array)
        {
            StringBuilder salida = new StringBuilder("");

            for (int i = 0; i < array.Length; i++)
            {
                salida.Append(array[1].ToString("X2"));
            }

            return salida.ToString();
        }

        private bool validar()
        {
            if (usernameTB.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese un usuario.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTB.Focus();
                return false;
            }

            if (passwordTB.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese una contraseña.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTB.Focus();
                return false;
            }

            return true;
        }
    }
}
