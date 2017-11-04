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

namespace PagoAgilFrba.Rendicion
{
    public partial class FrmRendicionFacturas : Form
    {
        private List<Control> label_obligatorios;
        private List<Control> campos_obligatorios;
        private List<Label> campo_labels;
        ControlHelper helper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        ClienteDAO clienteDAO = Singleton<ClienteDAO>.Instance;
        int id_empresa = -1;

        public FrmRendicionFacturas()
        {
            InitializeComponent();
            label_obligatorios = new List<Control>() { obligatoriosLbl , obligatorio1, obligatorio2, obligatorio3};
            campos_obligatorios = new List<Control>() { fechaRendicionDtp, empresaCb };
            campo_labels = new List<Label>() { fechaRendLb, empresaLb};
            helper.visualizar_controles(label_obligatorios, false);

            fillEmpresaCb();
        }

        private void fillEmpresaCb()
        {
            try
            {
                var dao = new EmpresaDAO();
                dao.setEmpresasHabilitadasCB(empresaCb);
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en Rendición de Facturas");
            }
        }

        #region Botones

        private void generarPagoBtn_Click(object sender, EventArgs e)
        {
            RendicionDAO rdao = new RendicionDAO();
            try
            {
                DateTime fecha = fechaRendicionDtp.Value;

                RendicionViewModel rendicion = rdao.getDatosRendicion(id_empresa, fecha );

                ImporteTotal.Text = Convert.ToDecimal(rendicion.importeTotal).ToString();
                ImporteComision.Text = Convert.ToDecimal(rendicion.importeEmpresa).ToString();
                porcentajeTextBox.Text = String.Concat(rendicion.porcentajeComision.ToString(), " %");

                if (rendicion.facturas.Count() == 0)
                {
                    MessageBox.Show("No se han encontrado registros.", "Listado Estadistico", MessageBoxButtons.OK);
                    facturasDgv.DataSource = null;
                    qttyTb.Text = "";
                }
                else
                {
                    var source = new BindingSource();
                    source.DataSource = rendicion.facturas;
                    facturasDgv.DataSource = source;
                    qttyTb.Text = rendicion.facturas.Count().ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = fechaRendicionDtp.Value;

            if (ImporteTotal.Text == null || ImporteTotal.Text == "")
                MessageBox.Show("Debe generar la rendicion", "Error en la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RendicionDAO rda = new RendicionDAO();
                try
                {
                    rda.RealizarRendicion(id_empresa, fecha);
                    MessageBox.Show("Se ha realizado la rendicion con exito.", "Registro de rendicion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            ImporteComision.Text = "";
            ImporteTotal.Text = "";
            porcentajeTextBox.Text = "";
            facturasDgv.DataSource = null;
            qttyTb.Text = "";
        }



        #endregion

        #region ?
        private void importeNud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmRendicionFacturas_Load(object sender, EventArgs e)
        {

        } 
        #endregion

        #region Botones cerrar / volver
        private void volverBtn_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void exitBtn_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helper.cerrar_app();
        }

        private void cerrarSesionHl_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helper.cerrar_sesion();
        } 
        #endregion

        private void empresaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemControlHelper.itemComboBox item = empresaCb.SelectedItem as ItemControlHelper.itemComboBox;

            id_empresa = item.id_item;

            if (id_empresa != -1)
            {
                this.generarPagoBtn.Enabled = true;
            }
        }

        
    }
}
