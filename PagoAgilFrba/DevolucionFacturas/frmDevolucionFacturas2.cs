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
        List<int> IdsFacturasSeleccionadas = new List<int>();

        public frmDevolucionFacturas2(FrmDevolucionFacturas _frmParent, Cliente _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
            frmParent = _frmParent;
            clienteLb.Text += cliente.nombre + " " + cliente.apellido;
        }

        private void frmDevolucionFacturas2_Load(object sender, EventArgs e)
        {
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
                if (IdsFacturasSeleccionadas.Count == 0)
                {
                    msgHelper.mostrar_error("Debe seleccionar por lo menos una factura para poder realizar la devolución.", "Error en Devolución de Facturas");
                    return;
                }

                if (string.IsNullOrWhiteSpace(motivoTb.Text))
                {
                    msgHelper.mostrar_error("Debe escribir un motivo de devolución previamente.", "Error en Devolución de Facturas");
                    return;
                }

                Devolucion devolucion = new Devolucion();
                devolucion.Id_Cliente = cliente.id;
                devolucion.Fecha_Devolucion = DateTime.Now;
                devolucion.Motivo = motivoTb.Text;
                devolucion.Facturas = IdsFacturasSeleccionadas;

                devolucionDao.realizar_devolucion(devolucion);
                msgHelper.mostrar_aviso("Devolucion exitosa", "RegistroPago de Pago");
                ctrlHelper.limpiar_tabla(facturasDgv);
                fill_facturas_dt();
                motivoTb.Text = string.Empty;
                totalTb.Text = "0";
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en Devolución de Facturas");
            }
        }

        private void fill_facturas_dt()
        {
            try
            {
                List<FacturaSimpleSeleccionable> facturasCliente = devolucionDao.obtener_facturas_devolucion(cliente.id);

                if (facturasCliente.Count == 0) {
                    MessageBox.Show("No se han encontrado facturas para el cliente seleccionado", "Error en Devolución de Facturas");
                }
                else
                {
                    var source = new BindingSource();
                    source.DataSource = facturasCliente;
                    facturasDgv.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en Devolución de Facturas");
            }
        }

        private void facturasDgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            IdsFacturasSeleccionadas.Clear();

            foreach (DataGridViewRow row in facturasDgv.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(true))
                {
                    row.Selected = true;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
                    total += Convert.ToDecimal(row.Cells[5].Value);
                    IdsFacturasSeleccionadas.Add(Convert.ToInt32(row.Cells[1].Value));
                }
                else
                    row.Selected = false;
            }

            totalTb.Text = total.ToString();
        }

        private void facturasDgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (facturasDgv.IsCurrentCellDirty)
            {
                facturasDgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

    }
}
