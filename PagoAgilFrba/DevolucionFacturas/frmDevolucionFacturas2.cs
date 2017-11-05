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
        DevolucionDAO devolucionDao = new DevolucionDAO();

        public frmDevolucionFacturas2(FrmDevolucionFacturas _frmParent, Cliente _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
            frmParent = _frmParent;
            clienteLb.Text += cliente.nombre + " " + cliente.apellido;
            fill_facturas_dt();
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
            try
            {
                if (string.IsNullOrWhiteSpace(motivoTb.Text))
                {
                    msgHelper.mostrar_error("Debe escribir un motivo de devolución previamente.", "Error en Devolución de Facturas");
                    return;
                }

                if (facturasDgv.SelectedRows.Count == 0)
                {
                    msgHelper.mostrar_error("Debe seleccionar por lo menos una factura para poder realizar la devolución.", "Error en Devolución de Facturas");
                    return;
                }

                Devolucion devolucion = new Devolucion();
                devolucion.Id_Cliente = cliente.id;
                devolucion.Fecha_Devolucion = DateTime.Now;
                devolucion.Motivo = motivoTb.Text;
                devolucion.Facturas = obtener_facturas_seleccionadas();

                devolucionDao.realizar_devolucion(devolucion);

            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en Devolución de Facturas");
            }
        }

        private void facturasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //calcular el total
        }

        private void fill_facturas_dt()
        {
            try
            {
                DataTable dt = devolucionDao.obtener_facturas_devolucion(cliente.id);

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No se han encontrado facturas para el cliente seleccionado", "Error en Devolución de Facturas");
                else
                    facturasDgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en Devolución de Facturas");
            }
        }

        private List<Factura> obtener_facturas_seleccionadas()
        {
            var lista = new List<Factura>();

            for (int i = 0; i < facturasDgv.SelectedRows.Count; i++)
            {
                var row = facturasDgv.SelectedRows[i];

                Factura fact = new Factura()
                {
                    id = Convert.ToInt32(row.Cells["IdFactura"].Value),
                };

                lista.Add(fact);
            }

            return lista;
        }
    }
}
