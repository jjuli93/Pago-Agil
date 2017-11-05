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
using PagoAgilFrba.Helpers;

namespace PagoAgilFrba.DevolucionFacturas
{
    public partial class FrmDevolucionFacturas : Form
    {
        int fila_seleccionada = -1;
        ControlHelper ctrlHelper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        ClienteDAO clienteDao = new ClienteDAO();
        int pantalla;

        public FrmDevolucionFacturas(int numeroPantalla)
        {
            InitializeComponent();
            pantalla = numeroPantalla;

            if (pantalla == 1)
                tituloPagoLbl.Hide();
            else
                tituloDevolucionLb.Hide();
        }

        #region "Botones de salida"
        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
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

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila_seleccionada < 0)
                {
                    msgHelper.mostrar_FilaNoSeleccionada();
                    return;
                }

                Cliente cliente = clienteDao.obtener_cliente_from_row(clientesDt.CurrentRow);

                if (cliente.id > 0)
                {
                    Form form;
                    if (pantalla == 1)
                        form = new frmDevolucionFacturas2(this, cliente);
                    else
                        form = new RegistroPago.FrmEjecucionPagoFactura(this, cliente);

                    form.Show();
                    this.Hide();
                }
                else
                    msgHelper.mostrar_error("Ha ocurrido un error al obtener los datos del cliente.", "Devoluciones de Facturas");
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error al seleccionar un Cliente");
            }
        }

        #region "Buscador"
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

        private void clientesDt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                siguienteBtn.Enabled = true;
                fila_seleccionada = e.RowIndex;
            }
        }
        #endregion

        private void fltDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlHelper.onlyIntNumbers_event(sender, e);
        }

    }
}
