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
        string default_description = string.Empty;
        int filaItem_seleccionado = -1;
        int filaFactura_seleccionada = -1;
        int id_cliente = -1;
        Factura factura_seleccionada = null;

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
            if (filaItem_seleccionado >= 0)
            {
                Form frmItem = new FrmItemFactura(this, true);
                frmItem.ShowDialog(this);
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void deleteToolBtn_Click(object sender, EventArgs e)
        {
            if (filaItem_seleccionado >= 0)
            {
                var total = Convert.ToDouble(totalTb.Text);
                total -= Convert.ToDouble(itemsDgv.Rows[filaItem_seleccionado].Cells[subtotalCol.Name].Value);
                totalTb.Text = total.ToString("F");
                itemsDgv.Rows.RemoveAt(filaItem_seleccionado);
                filaItem_seleccionado = -1;
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void clearAllToolBtn_Click(object sender, EventArgs e)
        {
            itemsDgv.Rows.Clear();
            itemsDgv.DataSource = null;
            totalTb.Text = "0";
        }

        private void itemsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaItem_seleccionado = e.RowIndex;
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

        private void itemsDgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;

            foreach (DataGridViewRow row in itemsDgv.Rows)
            {
                total += Convert.ToDouble(row.Cells[subtotalCol.Name].Value);
            }

            totalTb.Text = total.ToString("F");
        }

        private void itemsDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var total = Convert.ToDouble(totalTb.Text);
            total += Convert.ToDouble(itemsDgv.Rows[e.RowIndex].Cells[subtotalCol.Name].Value);
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
                    case "Nueva Factura":
                        do_insert();
                        break;
                    case "Modificar Factura":
                        do_update();
                        break;
                    case "Eliminar Factura":
                        do_delete();
                        break;
                }
            }
        }

        private void do_insert()
        {
            if (ctrlHelper.cumple_campos_obligatorios(obligatorios, errorProvider))
            {
                if (itemsDgv.Rows.Count == 0)
                {
                    msgHelper.mostrar_error("Debe ingresar por lo menos un item a la factura.", "Error en ABM Facturas");
                    return;
                }
                
                try
                {
                    Factura factura = obtener_factura_desde_form();

                    facturaDao.crear_factura(factura);

                    msgHelper.mostrar_aviso("Factura creada", "ABM Facturas");
                    limpiar_controles();
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
            try
            {
                if (!facturaDao.verificar_factura(Convert.ToInt32(facturasDgv.CurrentRow.Cells["IdFactura"].Value)))
                {
                    msgHelper.mostrar_error("No se puede modificar una factura que esta pagada y/o rendida.", "Error en ABM Facturas");
                    return;
                }

                //ACTUALIZO LOS ITEMS POR SI FUERON MODIFICADOS
                factura_seleccionada.items = obtener_items_desde_form();

                if (ctrlHelper.cumple_campos_obligatorios(obligatorios, errorProvider))
                {
                    if (factura_seleccionada.items.Count == 0)
                    {
                        msgHelper.mostrar_error("La factura debe contener por lo menos un item.", "Error en ABM Facturas");
                        return;
                    }

                    facturaDao.modificar_factura(factura_seleccionada);
                    msgHelper.mostrar_aviso("Factura modificada", "ABM Facturas");
                    limpiar_controles();
                    restablecer_controles();
                }
                else
                    msgHelper.mostrar_CamposIncompletos();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Facturas");
            }
        }

        private void do_delete()
        {
            try
            {
                if (!facturaDao.verificar_factura(Convert.ToInt32(facturasDgv.CurrentRow.Cells["IdFactura"].Value)))
                {
                    msgHelper.mostrar_error("No se puede eliminar una factura que esta pagada y/o rendida.", "Error en ABM Facturas");
                    return;
                }

                facturaDao.eliminar_factura(factura_seleccionada.id);
                msgHelper.mostrar_aviso("Factura eliminada", "ABM Facturas");
                limpiar_controles();
                restablecer_controles();   
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
            filaFactura_seleccionada = -1;
            filaItem_seleccionado = -1;
            totalTb.Text = "0";
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

        private Factura obtener_factura_desde_form()
        {
            Factura factura = new Factura()
            {
                id_cliente = this.id_cliente,
                nombre_cliente = this.clienteTb.Text,
                id_empresa = (this.empresaCb.SelectedItem as ItemControlHelper.itemComboBox).id_item,
                nombre_empresa = (this.empresaCb.SelectedItem as ItemControlHelper.itemComboBox).nombre_item,
                fecha_vencimiento = this.vencimientoDtp.Value,
                fecha_alta = DateTime.Now,
                habilitada = this.habilitadaChk.Checked,
                items = obtener_items_desde_form(),
                importe = Convert.ToDouble(totalTb.Text)
            };

            return factura;
        }

        private List<ItemFactura> obtener_items_desde_form()
        {
            List<ItemFactura> items = new List<ItemFactura>();

            foreach (DataGridViewRow item in itemsDgv.Rows)
            {
                items.Add(new ItemFactura()
                {
                    descripcion = item.Cells[DescItemCol.Name].Value.ToString(),
                    cantidad = Convert.ToInt32(item.Cells[CantCol.Name].Value.ToString()),
                    monto = Convert.ToDouble(item.Cells[montoCol.Name].Value.ToString())
                });
            }

            return items;
        }

        private Factura obtener_factura_desde_row()
        {
            if (filaFactura_seleccionada < 0)
                return null;

            DataGridViewRow row = facturasDgv.CurrentRow;

            Factura factura = new Factura()
            {
                id = Convert.ToInt32(row.Cells["IdFactura"].Value),
                id_cliente = Convert.ToInt32(row.Cells["IdCliente"].Value),
                id_empresa = Convert.ToInt32(row.Cells["IdEmpresa"].Value),
                numero_factura = Convert.ToUInt32(row.Cells["NumeroFactura"].Value),
                fecha_alta = Convert.ToDateTime(row.Cells["FechaAlta"].Value),
                fecha_vencimiento = Convert.ToDateTime(row.Cells["FechaVencimiento"].Value),
                importe = Convert.ToDouble(row.Cells["Importe"].Value),
                habilitada = (bool)row.Cells["Habilitada"].Value,
                items = obtener_items_desde_row()
            };

            return factura;
        }

        private List<ItemFactura> obtener_items_desde_row()
        {
            List<ItemFactura> items = new List<ItemFactura>();

            try
            {
                DataTable dt = facturaDao.obtener_items_factura(Convert.ToInt32(facturasDgv.CurrentRow.Cells["IdFactura"].Value));

                foreach (DataRow row in dt.Rows)
                {
                    items.Add(new ItemFactura()
                    {
                        descripcion = row[0].ToString(),
                        cantidad = Convert.ToInt32(row["Cantidad"].ToString()),
                        monto = Convert.ToDouble(row["Precio"].ToString()),
                    });
                }

            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Factura");
            }

            return items;
        }

        private void mostrar_factura_en_form(Factura factura)
        {
            if (factura_seleccionada == null)
            {
                msgHelper.mostrar_error("Ha ocurrido un error y no se ha podido mostrar los datos de la factura.", "Error en ABM Factura");
                return;
            }
                

            clienteTb.Text = factura.id.ToString();
            vencimientoDtp.Value = factura.fecha_vencimiento;
            habilitadaChk.Checked = factura.habilitada;

            foreach (ItemControlHelper.itemComboBox item in empresaCb.Items)
            {
                if (factura.id_empresa == item.id_item)
                {
                    empresaCb.SelectedItem = item;
                    break;
                }
            }

            foreach (ItemFactura item in factura.items)
            {
                itemsDgv.Rows.Add(item.descripcion, item.cantidad, item.monto, item.cantidad * item.monto);
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
        
        private void facturasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                limpiar_controles();
                filaFactura_seleccionada = e.RowIndex;
                factura_seleccionada = obtener_factura_desde_row();
                mostrar_factura_en_form(factura_seleccionada);
                restablecer_controles();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en Buscador de Facturas");
            }
        }
        #endregion

        

        
    }
}