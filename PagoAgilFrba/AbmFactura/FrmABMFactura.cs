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
using PagoAgilFrba.Datos;
using PagoAgilFrba.Negocio;
using PagoAgilFrba.AbmCliente;

namespace PagoAgilFrba.AbmFactura
{
    public partial class FrmABMFactura : Form
    {
        List<Control> obligatorios;
        ControlHelper ctrlHelper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        public double total = 0;
        string default_description = string.Empty;
        int filaItem_seleccionada = -1;
        int filaFactura_seleccionada = -1;
        int id_cliente = -1;

        public FrmABMFactura()
        {
            InitializeComponent();
            obligatorios = new List<Control>() { clienteTb, empresaCb, vencimientoDtp };
            fillComboEmpresas();
            descripcionLbl.Text = default_description;
        }

        private void fillComboEmpresas()
        {
            try
            {
                var empDao = new EmpresaDAO();
                empDao.setEmpresasHabilitadasCB(empresaCb);
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Factura");
            }
        }

        #region "Exit Buttons"
        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlHelper.cerrar_app();
        }

        private void cerrarSesionHl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlHelper.cerrar_sesion();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Close();
            }
        }
        #endregion

        #region "ToolStrip Buttons"
        private void addToolBtn_Click(object sender, EventArgs e)
        {
            Form frmItem = new FrmItemFactura(this, false);
            frmItem.ShowDialog();
        }

        private void editToolBtn_Click(object sender, EventArgs e)
        {
            if (filaItem_seleccionada >= 0)
            {
                Form frmItem = new FrmItemFactura(this, true);
                frmItem.ShowDialog(this);
                //TODO: ACTUALIZAR EL TOTAL
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void deleteToolBtn_Click(object sender, EventArgs e)
        {
            if (filaItem_seleccionada >= 0)
            {
                total += Convert.ToDouble(itemsDgv.Rows[filaItem_seleccionada].Cells[subtotalCol.Name].Value);
                totalTb.Text = total.ToString("F");
                itemsDgv.Rows.RemoveAt(filaItem_seleccionada);
                filaItem_seleccionada = -1;
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void clearAllToolBtn_Click(object sender, EventArgs e)
        {
            itemsDgv.Rows.Clear();
            itemsDgv.DataSource = null;
        }
        #endregion

        private void itemsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaItem_seleccionada = e.RowIndex;
        }

        private void fnticClientesBtn_Click(object sender, EventArgs e)
        {
            FrmBuscadorClientesLite finder = new FrmBuscadorClientesLite(this);
            finder.Show();
            this.Hide();
        }

        public void set_cliente_seleccionado(Cliente cliente)
        {
            if (cliente != null)
            {
                if (cliente.habilitado)
                {
                    clienteTb.Text = String.Format("{0} {1}", cliente.nombre, cliente.apellido);
                    id_cliente = cliente.id;
                }
                else
                    msgHelper.mostrar_error("El cliente seleccionado se encuentra deshabilitado, por favor seleccione otro.", "Error en ABM de Facturas");
            }
        }

        private void itemsDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            total += Convert.ToDouble(itemsDgv.Rows[e.RowIndex].Cells["Subtotal"].Value);
            totalTb.Text = total.ToString("F");
        }

    }
}
