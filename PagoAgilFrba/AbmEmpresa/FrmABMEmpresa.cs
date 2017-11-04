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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class FrmABMEmpresa : Form
    {
        private string default_description = "";
        private List<Control> label_obligatorios;
        private List<Control> campos_obligatorios;
        private List<Label> campo_labels;
        ControlHelper helper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        EmpresaDAO empresaDao = new EmpresaDAO();
        int fila_seleccionada = -1;

        public FrmABMEmpresa()
        {
            InitializeComponent();
            descripcionLbl.Text = default_description;
            label_obligatorios = new List<Control>() { obligatoriosLbl, obligatorio1, obligatorio2, obligatorio3, obligatorio4 };
            campos_obligatorios = new List<Control>() { nombreTb, cuitTb, direccionTb, rubroCb };
            campo_labels = new List<Label>() { nombreLb, cuitLb, dirLb, rubroLb };
            helper.visualizar_controles(label_obligatorios, false);
            habilitar_todo(false);
            habilitadoChk.Visible = false;
            fillCbRubros();
        }

        #region "Commons"
        public void habilitar_todo(bool valor_hab)
        {
            helper.habilitar_controles(campos_obligatorios, valor_hab);
            habilitadoChk.Enabled = valor_hab;
        }

        private void restablecer_controles()
        {
            confirmPnl.Visible = false;
            abmPnl.Visible = true;
            descripcionLbl.Text = default_description;
            helper.visualizar_controles(label_obligatorios, false);
            habilitar_todo(false);
            habilitadoChk.Visible = false;
            helper.limpiar_errorProvider(campos_obligatorios, errorProvider);
            empresasDt.ReadOnly = false;
        }

        private void limpiar_campos()
        {
            nombreTb.Text = string.Empty;
            direccionTb.Text = string.Empty;
            cuitTb.Text = string.Empty;
            habilitadoChk.Checked = false;
            rubroCb.SelectedIndex = -1;
            fila_seleccionada = -1;
        }

        public void fillCbRubros()
        {
            try
            {
                empresaDao.setRubrosCB(rubroCb);
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Empresa");
            }
        }

        public Empresa obtener_empresa_desde_form() 
        {
            try
            {
                Empresa emp = new Empresa();

                emp.nombre = nombreTb.Text.Trim();
                emp.direccion = direccionTb.Text.Trim();
                emp.cuit = cuitTb.Text.Trim();
                emp.rubro = (ItemControlHelper.itemComboBox) rubroCb.SelectedItem;
                emp.habilitado = habilitadoChk.Checked;

                return emp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void obtener_empresa_desde_row()
        {
            try
            {
                DataGridViewRow row = empresasDt.SelectedRows[0];

                nombreTb.Text = row.Cells["Nombre"].Value.ToString();
                direccionTb.Text = row.Cells["Direccion"].Value.ToString();
                cuitTb.Text = row.Cells["CUIT"].Value.ToString();
                habilitadoChk.Checked = Convert.ToBoolean(Convert.ToInt32(row.Cells["Habilitada"].Value));

                var found = false;
                int i;
                for (i = 0; i < rubroCb.Items.Count; i++)
                {
                    var rubro = (ItemControlHelper.itemComboBox)rubroCb.Items[i];
                    if (rubro.nombre_item == row.Cells[5].Value.ToString()) //TODO CAMBIAR POR EL NOMBRE DE LA COLUMNA
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                    rubroCb.SelectedIndex = i; 
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region "Botones de salida"
        private void exitBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helper.cerrar_app();
        }

        private void cerrarSesionHl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helper.cerrar_sesion();
        }
        #endregion

        #region "Botones ABM"
        private void crearBtn_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Crear Empresa";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
            empresasDt.ReadOnly = true;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada >= 0)
            {
                confirmPnl.Visible = true;
                abmPnl.Visible = false;
                descripcionLbl.Text = "Modificar Empresa";
                helper.visualizar_controles(label_obligatorios, true);
                habilitar_todo(true);
                habilitadoChk.Visible = true;
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada >= 0)
            {
                confirmPnl.Visible = true;
                abmPnl.Visible = false;
                descripcionLbl.Text = "Eliminar Empresa";
            }
            else
                msgHelper.mostrar_FilaNoSeleccionada();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            habilitar_todo(true);
            direccionTb.Enabled = false;
            descripcionLbl.Text = "Buscador";
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        #endregion

        #region "Botones confirmar"
        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string operacion = descripcionLbl.Text;
            string msg = string.Format("¿Confirmar <{0}>?", operacion);

            if (MessageBox.Show(msg, "PagoAgil FRBA App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                helper.limpiar_errorProvider(campos_obligatorios, errorProvider);

                switch (operacion)
                {
                    case "Crear Empresa":
                        do_insert();
                        break;
                    case "Modificar Empresa":
                        do_update();
                        break;
                    case "Eliminar Empresa":
                        do_delete();
                        break;
                    case "Buscador":
                        do_search();
                        break;
                }
                restablecer_controles();
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            restablecer_controles();
        }
        #endregion 

        #region "Operaciones"
        private void do_insert()
        {
            try
            {
                if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
                {
                    empresaDao.crear_empresa(obtener_empresa_desde_form());
                    msgHelper.mostrar_aviso("Se ha creado la empresa.", "Alta de Empresa");
                    limpiar_campos();
                }
                else
                    msgHelper.mostrar_CamposIncompletos();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Empresa");
            }
        }

        private void do_update()
        {
            try
            {
                if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
                {
                    Empresa emp = obtener_empresa_desde_form();
                    emp.id = Convert.ToInt32(empresasDt.CurrentRow.Cells["IdEmpresa"].Value);

                    empresaDao.modificar_empresa(emp);
                    msgHelper.mostrar_aviso("Se ha modificado la empresa.", "Modificación de Empresa");
                    limpiar_campos();
                    restablecer_controles();
                }
                else
                    msgHelper.mostrar_CamposIncompletos();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Empresa");
            }
        }

        private void do_delete()
        {
            try
            {
                int id = Convert.ToInt32(empresasDt.CurrentRow.Cells["IdEmpresa"].Value);

                empresaDao.eliminar_empresa(id);
                msgHelper.mostrar_aviso("Se ha dado de baja a la empresa.", "Baja de Empresa");
                limpiar_campos();
                restablecer_controles();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Empresa");
            }
        }

        private void do_search()
        {
            empresasDt.DataSource = null;
            try
            {
                string nombreFlt = nombreTb.Text.Trim();
                string cuitFlt = cuitTb.Text.Trim();

                int rubroFlt = -1;
                if (rubroCb.SelectedIndex >= 0)
                    rubroFlt = ((ItemControlHelper.itemComboBox)rubroCb.SelectedItem).id_item;

                DataTable dt = empresaDao.buscar_empresas(nombreFlt, cuitFlt, rubroFlt);

                if (dt.Rows.Count != 0)
                    empresasDt.DataSource = dt;
                else
                    msgHelper.mostrar_aviso("No se han encontrado registros", "Buscador de Empresas");
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Empresa");
            }
        }
        #endregion

        private void empresasDt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                limpiar_campos();
                restablecer_controles();
                this.fila_seleccionada = e.RowIndex;
                obtener_empresa_desde_row();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Empresa");
            }
        }

        private void habilitadoChk_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
