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

namespace PagoAgilFrba.RegistroPago
{
    public partial class FrmEjecucionPagoFactura : Form
    {
        Cliente cliente = null;
        DevolucionFacturas.FrmDevolucionFacturas frmParent = null;
        ControlHelper ctrlHelper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        List<int> IdsFacturasSeleccionadas = new List<int>();
        int IdMedioPagoSeleccionado = -1;
        List<FacturaSimpleSeleccionable> facturasCliente = new List<FacturaSimpleSeleccionable>();


        public FrmEjecucionPagoFactura(DevolucionFacturas.FrmDevolucionFacturas _frmParent, Cliente _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
            frmParent = _frmParent;
            clienteLb.Text += cliente.nombre + " " + cliente.apellido;

            PagoDAO pagoDAO = new PagoDAO();
            pagoDAO.setMediosPagoCB(MediosPagoCB);
            facturasCliente = pagoDAO.GetFacturasClienteParaPago(_cliente.id);
            llenarTabla();
        }


        private void llenarTabla()
        {
            var source = new BindingSource();
            source.DataSource = facturasCliente;
            dataGridView1.DataSource = source;
        }
        private void devolverBtn_Click(object sender, EventArgs e)
        {
            PagoDAO pagoDAO = new PagoDAO();
            bool error = false;

            if (IdsFacturasSeleccionadas.Count == 0)
            {
                msgHelper.mostrar_error("Debe seleccionar por lo menos una factura", "Registro de pago");
                error = true;
            }
            if (IdMedioPagoSeleccionado == -1)
            {
                msgHelper.mostrar_error("Debe seleccionar un medio de pago.", "Registro de pago");
                error = true;            
            }

            if (!error)
            {
                pagoDAO.RealizarPago(IdsFacturasSeleccionadas, cliente.id, 1, IdMedioPagoSeleccionado);
                msgHelper.mostrar_aviso("Pago registrado", "RegistroPago de Pago");
                frmParent.Show();
                this.Close();
            }
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

        private void MediosPagoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemControlHelper.itemComboBox item = MediosPagoCB.SelectedItem as ItemControlHelper.itemComboBox;

            IdMedioPagoSeleccionado = item.id_item;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            decimal total = 0;
            IdsFacturasSeleccionadas.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
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

            TotalTB.Text = total.ToString();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }





    }
}
