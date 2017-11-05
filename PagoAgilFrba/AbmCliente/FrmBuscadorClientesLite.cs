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
using PagoAgilFrba.Helpers;
using PagoAgilFrba.Negocio;

namespace PagoAgilFrba.AbmCliente
{
    public partial class FrmBuscadorClientesLite : Form
    {
        int fila_seleccionada = -1;
        ControlHelper ctrlHelper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        ClienteDAO clienteDao = new ClienteDAO();

        public FrmBuscadorClientesLite(dynamic _frmParent)
        {
            InitializeComponent();
            this.Owner = _frmParent;
        }

        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            clientesDt.DataSource = null;
            try
            {
                var dt = clienteDao.buscar_clientes(fltNombre.Text.Trim(), fltApellido.Text.Trim(), fltDNI.Text.Trim(), "");

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No se han encontrado registros", "Buscador de Clientes");
                else
                    clientesDt.DataSource = dt;
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en el buscador de clientes");
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            this.clientesDt.ClearSelection();
            this.clientesDt.DataSource = null;
            fila_seleccionada = -1;
            fltNombre.Text = "";
            fltDNI.Text = "";
            fltApellido.Text = "";
        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila_seleccionada < 0)
                {
                    msgHelper.mostrar_FilaNoSeleccionada();
                    return;
                }

                Cliente cliente = clienteDao.obtener_cliente_from_row(clientesDt.CurrentRow);

                (this.Owner as dynamic).set_cliente_seleccionado(cliente);
                this.Owner.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error al seleccionar un Cliente");
            }
        }

        private void fltDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlHelper.onlyIntNumbers_event(sender, e);
        }

        private void clientesDt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila_seleccionada = e.RowIndex;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
