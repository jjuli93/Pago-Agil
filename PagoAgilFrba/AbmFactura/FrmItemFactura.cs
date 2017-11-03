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

namespace PagoAgilFrba.AbmFactura
{
    public partial class FrmItemFactura : Form
    {
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        FrmABMFactura abmFactura = null;
        bool itsUpdate = false;

        public FrmItemFactura(bool modAction)
        {
            InitializeComponent();
            abmFactura = this.Owner as FrmABMFactura; /////VUEVA TODO A LA MIERDAAAAAAAA

            if (itsUpdate = modAction)
            {
                continueBtn.Visible = false;
                crearBtn.Text = "Guardar";
                groupBox.Text = "Modificar item";

                var item = abmFactura.itemsDgv.SelectedRows[0];
                descTb.Text = item.Cells[abmFactura.DescItemCol.Name].Value.ToString();
                qttyNud.Value = Convert.ToInt32(item.Cells[abmFactura.CantCol.Name].Value);
                montoNud.Value = Convert.ToInt32(item.Cells[abmFactura.montoCol.Name].Value);
            }
        }

        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (validar_campos())
            {
                var qtty = qttyNud.Value;
                var monto = montoNud.Value;
                var subtotal = qtty * monto;

                abmFactura.itemsDgv.Rows.Add(descTb.Text, qtty.ToString(), monto.ToString(), subtotal.ToString());
                limpiar_controles();
            }
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            if (validar_campos())
            {
                var qtty = qttyNud.Value;
                var monto = montoNud.Value;
                var subtotal = qtty * monto;

                if (itsUpdate)
                {
                    var row = abmFactura.itemsDgv.SelectedRows[0];
                    row.Cells[abmFactura.DescItemCol.Name].Value = descTb.Text;
                    row.Cells[abmFactura.CantCol.Name].Value = qtty.ToString();
                    row.Cells[abmFactura.montoCol.Name].Value = monto.ToString();
                    row.Cells[abmFactura.subtotalCol.Name].Value = subtotal.ToString();
                }
                else
                    abmFactura.itemsDgv.Rows.Add(descTb.Text, qtty.ToString(), monto.ToString(), subtotal.ToString());

                this.Close();
            }
        }

        private void limpiar_controles()
        {
            descTb.Text = string.Empty;
            qttyNud.Value = 0;
            montoNud.Value = 0;
        }

        private bool validar_campos()
        {
            if (string.IsNullOrWhiteSpace(descTb.Text))
            {
                msgHelper.mostrar_error("Ingrese una descripción por favor.", "Item Factura");
                return false;
            }

            if (qttyNud.Value <= 0)
            {
                msgHelper.mostrar_error("Ingrese una cantidad por favor.", "Item Factura");
                return false;
            }

            if (montoNud.Value <= 0)
            {
                msgHelper.mostrar_error("Ingrese un monto por favor.", "Item Factura");
                return false;
            }

            return true;
        }
    }
}
