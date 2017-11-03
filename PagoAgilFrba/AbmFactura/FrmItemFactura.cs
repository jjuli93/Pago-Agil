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

        public FrmItemFactura(bool modAction)
        {
            InitializeComponent();
            abmFactura = (FrmABMFactura)this.Owner;

            if (modAction)
            {
                continueBtn.Visible = false;
                crearBtn.Text = "Guardar";
                groupBox.Text = "Modificar item";
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

                abmFactura.itemsDgv.Rows.Add(new DataGridViewCheckBoxCell(), descTb.Text, qtty.ToString(), monto.ToString(), subtotal.ToString());
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

                abmFactura.itemsDgv.Rows.Add(new DataGridViewCheckBoxCell(), descTb.Text, qtty.ToString(), monto.ToString(), subtotal.ToString());
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

            if (qttyNud.Value > 0)
            {
                msgHelper.mostrar_error("Ingrese una cantidad por favor.", "Item Factura");
                return false;
            }

            if (montoNud.Value > 0)
            {
                msgHelper.mostrar_error("Ingrese un monto por favor.", "Item Factura");
                return false;
            }

            return true;
        }
    }
}
