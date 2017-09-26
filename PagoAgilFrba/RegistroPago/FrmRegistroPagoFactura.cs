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
using PagoAgilFrba.Helpers;

namespace PagoAgilFrba.RegistroPago
{
    public partial class FrmRegistroPagoFactura : Form
    {
        List<PagoFactura> facturas_cargadas = new List<PagoFactura>();
        List<Control> campos_obligatorios = null;
        int _indexfactura_seleccionada;
        ItemControlHelper itemHelper = Singleton<ItemControlHelper>.Instance;
        ControlHelper controlHelper = Singleton<ControlHelper>.Instance;

        public FrmRegistroPagoFactura()
        {
            InitializeComponent();
            generar_columnas();
            campos_obligatorios = new List<Control>() { nroFacturaTb, fechaCobroDtp, empresaCb, clienteCb, vencimientoDtp, importeNud, sucursalTb };
        }

        public void generar_columnas()
        {
            facturasDgv.Columns.Add("Nro Factura", "Nro Factura");
            facturasDgv.Columns.Add("Importe", "Importe");
            facturasDgv.Columns.Add("Fecha cobro", "Fecha cobro");
            facturasDgv.Columns.Add("Empresa", "Empresa");
            facturasDgv.Columns.Add("Cliente", "Cliente");
            facturasDgv.Columns.Add("Vencimiento", "Vencimiento");
            facturasDgv.Columns.Add("Sucursal", "Sucursal");
        }

        public void cargar_datos_desde_tabla()
        {
            if (_indexfactura_seleccionada > 0)
            {
                try
                {
                    var row = facturasDgv.Rows[_indexfactura_seleccionada];

                    nroFacturaTb.Text = (string)row.Cells["Nro Factura"].Value;
                    fechaCobroDtp.Value = Convert.ToDateTime(row.Cells["Fecha cobro"].Value);
                    itemHelper.select_in_combo(row.Cells["Empresa"].Value.ToString(), empresaCb);
                    itemHelper.select_in_combo(row.Cells["Cliente"].Value.ToString(), clienteCb);
                    vencimientoDtp.Value = Convert.ToDateTime(row.Cells["Vencimiento"].Value);
                    sucursalTb.Text = row.Cells["Sucursal"].Value.ToString();
                    importeNud.Value = Convert.ToDecimal(row.Cells["Importe"].Value);
                }
                catch (Exception)
                {
                    //no hace nada....
                }
            }
        }

        public void cargar_datos_a_la_tabla()
        {
            try
            {
                DataGridViewRow row = (DataGridViewRow)facturasDgv.Rows[0].Clone();

                row.Cells["Nro Factura"].Value = nroFacturaTb.Text;
                row.Cells["Fecha cobro"].Value = fechaCobroDtp.Value.ToShortDateString();
                row.Cells["Empresa"].Value = empresaCb.SelectedItem.ToString();
                row.Cells["Cliente"].Value = clienteCb.SelectedItem.ToString();
                row.Cells["Vencimiento"].Value = vencimientoDtp.Value.ToShortDateString();
                row.Cells["Sucursal"].Value = sucursalTb.Text;
                row.Cells["Importe"].Value = importeNud.Value.ToString();

                facturasDgv.Rows.Add(row);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void facturasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _indexfactura_seleccionada = e.RowIndex;

            cargar_datos_desde_tabla();
        }

        #region "Botones de salida"
        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHelper.cerrar_app();
        }

        private void cerrarSesionHl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHelper.cerrar_sesion();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region "Botones principales"
        private void crearBtn_Click(object sender, EventArgs e)
        {
            controlHelper.limpiar_errorProvider(campos_obligatorios, errorProvider);

            try
            {
                if (validar_campos())
                {
                    cargar_datos_a_la_tabla();
                    controlHelper.limpiar_controles(this);
                }
                else
                {
                    MessageBox.Show("Por favor verfique los datos ingresados.", "Pago de facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al intentar registrar una factura.", "Pago de facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generarPagoBtn_Click(object sender, EventArgs e)
        {
            if (facturasDgv.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Confirmar pago de facturas?", "Pago de facturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    var execPagoDlg = new FrmEjecucionPagoFactura();
                    execPagoDlg.Owner = this;
                    execPagoDlg.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Debe cargar por lo menos una factura antes de realizar el pago", "Pago de facturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region "Botones del Tooltrip"
        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            controlHelper.limpiar_errorProvider(campos_obligatorios, errorProvider);

            try
            {
                foreach (DataGridViewRow item in this.facturasDgv.SelectedRows)
                {
                    facturasDgv.Rows.RemoveAt(item.Index);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar un registro.", "Eliminación de Pago Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            controlHelper.limpiar_errorProvider(campos_obligatorios, errorProvider);
            DataGridViewRow row = null;

            try
            {
                if ((row = facturasDgv.CurrentRow) == null)
                    return;

                if (validar_campos())
                {
                    row.Cells["Nro Factura"].Value = nroFacturaTb.Text;
                    row.Cells["Fecha cobro"].Value = fechaCobroDtp.Value.ToShortDateString();
                    row.Cells["Empresa"].Value = empresaCb.SelectedItem.ToString();
                    row.Cells["Cliente"].Value = clienteCb.SelectedItem.ToString();
                    row.Cells["Vencimiento"].Value = vencimientoDtp.Value.ToShortDateString();
                    row.Cells["Sucursal"].Value = sucursalTb.Text;
                    row.Cells["Importe"].Value = importeNud.Value.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor verfique los datos ingresados.", "Modificación de Pago Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al intentar guardar los cambios.", "Modificación de Pago Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            controlHelper.limpiar_errorProvider(campos_obligatorios, errorProvider);
            if (facturasDgv.SelectedRows.Count > 0)
                controlHelper.limpiar_controles(this);

            controlHelper.limpiar_tabla(facturasDgv);
            _indexfactura_seleccionada = -1;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            controlHelper.limpiar_errorProvider(campos_obligatorios, errorProvider);
            _indexfactura_seleccionada = -1;
            controlHelper.limpiar_controles(this);
            facturasDgv.ClearSelection();
        }
        #endregion

        public bool validar_campos()
        {
            var cond1 = true;
            if (vencimientoDtp.Value <= DateTime.Now)
            {
                errorProvider.SetError(vencimientoDtp, "La fecha de vencimiento no debe ser menor a la actual");
                cond1 = false;
            }
            var cond2 = controlHelper.cumple_campos_obligatorios(campos_obligatorios, errorProvider);

            return cond1 & cond2;
        }

        
    }
}
