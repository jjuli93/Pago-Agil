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

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class FrmTopEstadistico : Form
    {
        ControlHelper ctrl_helper = Singleton<ControlHelper>.Instance;
        List<RadioButton> rbs;
        int default_year = DateTime.Now.Year;

        public FrmTopEstadistico()
        {
            InitializeComponent();
            rbs = new List<RadioButton>() { facturasCobradasRb, mayorRendicionRb, masPagosRb, clienteCumplidorRb };
            inicializar_trimestres();
            yearNud.Maximum = DateTime.Now.Year;
            yearNud.Value = default_year;
        }

        private void inicializar_trimestres()
        {
            trimestreCb.Items.Add(new ItemControlHelper.itemComboBox("1er Trimestre [Ene-Mar]", 1));
            trimestreCb.Items.Add(new ItemControlHelper.itemComboBox("2do Trimestre [Abr-Jun]", 2));
            trimestreCb.Items.Add(new ItemControlHelper.itemComboBox("3ro Trimestre [Jul-Sep]", 3));
            trimestreCb.Items.Add(new ItemControlHelper.itemComboBox("4to Trimestre [Oct-Dic]", 4));
        }

        private RadioButton obtener_seleccionado()
        {
            RadioButton rb = null;

            rb = rbs.Find(x => x.Checked == true);

            return rb;
        }

        private bool validar()
        {
            RadioButton rb = obtener_seleccionado();

            if (rb == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de listado.", "Error en Listado Estadistico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (yearNud.Value <= 0)
            {
                MessageBox.Show("Debe ingresar un año.", "Error en Listado Estadistico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (trimestreCb.SelectedItem == null || trimestreCb.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un trimestre.", "Error en Listado Estadistico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                try
                {
                    TopDAO topDao = new TopDAO();
                    int anio = (int)yearNud.Value;
                    ItemControlHelper.itemComboBox trimestre = (ItemControlHelper.itemComboBox)trimestreCb.SelectedItem;
                    int listado = rbs.IndexOf(obtener_seleccionado()) + 1;

                    DataTable dt = topDao.consultar_listado(anio, trimestre.id_item, listado);

                    if (dt.Rows.Count != 0)
                        listadoDgv.DataSource = dt;
                    else
                        MessageBox.Show("No se han encontrado registros.", "Listado Estadistico", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en Listado Estadisco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
        }

        private void check_rbs(bool check_value)
        {
            facturasCobradasRb.Checked = check_value;
            mayorRendicionRb.Checked = check_value;
            masPagosRb.Checked = check_value;
            clienteCumplidorRb.Checked = check_value;
        }

        private void clean_fields() 
        {
            yearNud.Value = default_year;
            trimestreCb.SelectedIndex = -1;
            trimestreCb.Text = string.Empty;
            trimestreCb.SelectedItem = null;
            check_rbs(false);
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            clean_fields();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            clean_fields();
            listadoDgv.DataSource = null;
        }

        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrl_helper.cerrar_app();
        }

        private void cerrarSesionHl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrl_helper.cerrar_sesion();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

    }
}
