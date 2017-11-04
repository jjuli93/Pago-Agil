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
        FacturaDAO facturaDao = new FacturaDAO();
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
            mostrar_obligatorios(false);
            habilitadaChk.Visible = false;
            habilitar_campos(false);
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

        private void itemsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaItem_seleccionada = e.RowIndex;
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
        #endregion

        #region "ABM Buttons"
        private void crearBtn_Click(object sender, EventArgs e)
        {
            limpiar_controles();
            descripcionLbl.Text = "Nueva Factura";
            abmPnl.Visible = false;
            confirmPnl.Visible = true;
            habilitar_campos(true);
            mostrar_obligatorios(true);
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (filaFactura_seleccionada >= 0)
            {
                descripcionLbl.Text = "Modificar Factura";
                abmPnl.Visible = false;
                confirmPnl.Visible = true;
                habilitar_campos(true);
                mostrar_obligatorios(true);
                habilitadaChk.Visible = true;
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (filaFactura_seleccionada >= 0)
            {
                descripcionLbl.Text = "Eliminar Factura";
                abmPnl.Visible = false;
                confirmPnl.Visible = true;
                habilitadaChk.Visible = true;
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }
        #endregion

        #region "Confirm Buttons"
        private void cancelarBtn_Click(object sender, EventArgs e)
        {            
            restablecer_controles();
            limpiar_controles();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string operacion = descripcionLbl.Text;
            string msg = string.Format("¿Confirmar <{0}>?", operacion);

            if (msgHelper.mostrar_confirmacion(msg, "ABM Facturas") == DialogResult.Yes)
            {
                ctrlHelper.limpiar_errorProvider(obligatorios, errorProvider);

                switch (operacion)
                {
                    case "Crear Cliente":
                        do_insert();
                        break;
                    case "Modificar Cliente":
                        do_update();
                        break;
                    case "Eliminar Cliente":
                        do_delete();
                        break;
                }
            }
        }

        private void do_insert()
        {
            if (ctrlHelper.cumple_campos_obligatorios(obligatorios, errorProvider))
            {
                try
                {
                    
                }
                catch (Exception ex)
                {
                    msgHelper.mostrar_error(ex.Message, "Error en ABM Facturas");
                }
            }
            else
                msgHelper.mostrar_CamposIncompletos();
        }

        private void do_update()
        {
            if (ctrlHelper.cumple_campos_obligatorios(obligatorios, errorProvider))
            {
                try
                {
                    
                }
                catch (Exception ex)
                {
                    msgHelper.mostrar_error(ex.Message, "Error en ABM Facturas");
                }

                this.restablecer_controles();
            }
            else
                msgHelper.mostrar_CamposIncompletos();
        }

        private void do_delete()
        {
            try
            {
                if (id_cliente > 0)
                {
                    
                }
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Facturas");
            }
        }
        #endregion

        #region "Commons"
        private void restablecer_controles()
        {
            confirmPnl.Visible = false;
            abmPnl.Visible = true;
            descripcionLbl.Text = default_description;
            mostrar_obligatorios(false);
            habilitadaChk.Visible = false;
            ctrlHelper.limpiar_errorProvider(obligatorios, errorProvider);
            habilitar_campos(false);
        }

        private void limpiar_controles()
        {
            clienteTb.Text = string.Empty;
            id_cliente = -1;
            empresaCb.SelectedIndex = -1;
            empresaCb.Text = string.Empty;
            vencimientoDtp.Value = DateTime.Now;
            habilitadaChk.Checked = false;
            itemsDgv.Rows.Clear();
            itemsDgv.DataSource = null;
        }

        private void habilitar_campos(bool valor)
        {
            clienteTb.Enabled = valor;
            empresaCb.Enabled = valor;
            vencimientoDtp.Enabled = valor;
            habilitadaChk.Enabled = valor;
            itemsPnl.Enabled = valor;
            fnticClientesBtn.Enabled = valor;
        }

        private void fnticClientesBtn_Click(object sender, EventArgs e)
        {
            FrmBuscadorClientesLite finder = new FrmBuscadorClientesLite(this);
            finder.Show();
            this.Hide();
        }

        private void mostrar_obligatorios(bool valor)
        {
            obligatorio1.Visible = valor;
            obligatorio2.Visible = valor;
            obligatorio3.Visible = valor;
            obligatoriosLbl.Visible = valor;
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
        #endregion

        #region "Buscador"
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            facturasDgv.DataSource = null;
            try
            {
                var dt = facturaDao.buscar_facturas(nroFactFlt.Text.Trim(), clienteFlt.Text.Trim());

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No se han encontrado registros", "Buscador de Facturas");
                else
                    facturasDgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en el buscador de facturas");
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            nroFactFlt.Text = string.Empty;
            clienteFlt.Text = string.Empty;
            ctrlHelper.limpiar_tabla(facturasDgv);
            limpiar_controles();
            restablecer_controles();
        }

        private void nroFactFlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlHelper.onlyIntNumbers_event(sender, e);
        }

        private void clienteFlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrlHelper.onlyIntNumbers_event(sender, e);
        }
        #endregion

    }
}