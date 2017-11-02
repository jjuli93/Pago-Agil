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

namespace PagoAgilFrba.AbmRol
{
    public partial class FrmABMRol : Form
    {
        private string default_description = "null";
        private List<Control> label_obligatorios;
        private List<Control> campos_obligatorios;
        private List<Label> campo_labels;
        ControlHelper helper = Singleton<ControlHelper>.Instance;
        MessageHelper msgHelper = Singleton<MessageHelper>.Instance;
        RolDAO rolDao = new RolDAO();
        int fila_seleccionada = -1;
        int id_rol_seleccionado = -1;

        public FrmABMRol()
        {
            InitializeComponent();
            descripcionLbl.Text = default_description;
            fill_fns_sistema();
            fill_roles_sistema();
            label_obligatorios = new List<Control>() { obligatoriosLbl, obligatorio1, obligatorio2 };
            campos_obligatorios = new List<Control>() { nombreTb, fnsChkList };
            campo_labels = new List<Label>() { nombreLb, funcsLb };
            helper.visualizar_controles(label_obligatorios, false);
            habilitar_todo(false);
            habilitadoChk.Visible = false;
            rolesGrid.ClearSelection();
            rolesGrid.CurrentCell = null;
        }

        #region "Botones"
        private void crearBtn_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            confirmPnl.Visible = true;
            abmPnl.Visible = false;
            descripcionLbl.Text = "Crear Rol";
            helper.visualizar_controles(label_obligatorios, true);
            habilitar_todo(true);
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada >= 0)
            {
                confirmPnl.Visible = true;
                abmPnl.Visible = false;
                descripcionLbl.Text = "Modificar Rol";
                helper.visualizar_controles(label_obligatorios, true);
                habilitar_todo(true);
                habilitadoChk.Visible = true;
            }
            else
            {
                msgHelper.mostrar_FilaNoSeleccionada();
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada >= 0)
            {
                confirmPnl.Visible = true;
                abmPnl.Visible = false;
                descripcionLbl.Text = "Eliminar Rol";
            }
            else
            {
                msgHelper.mostrar_FilaNoSeleccionada();
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            restablecer_controles();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            string operacion = descripcionLbl.Text;
            string msg = string.Format("¿Confirmar <{0}>?", operacion);

            if (msgHelper.mostrar_confirmacion(msg, "PagoAgil FRBA App") == DialogResult.Yes)
            {
                switch (operacion)
                {
                    case "Crear Rol":
                        do_insert();
                        break;
                    case "Modificar Rol":
                        do_update();
                        break;
                    case "Eliminar Rol":
                        do_delete();
                        break;
                }
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
        
        #region "ALTA-BAJA-MODIFICACIONES"
        //**************** ALTA ROL ********************
        private void do_insert()
        {
            if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
            {
                try
                {
                    rolDao.crear_rol(nombreTb.Text, obtener_fns_seleccionadas());
                    msgHelper.mostrar_aviso("Se ha creado el nuevo rol", "Alta de Rol");

                    actualizar_roles();
                    limpiar_campos();
                    restablecer_controles();
                }
                catch (Exception ex)
                {
                    msgHelper.mostrar_error(ex.Message, "Error en Alta de Rol");
                }
 
                 this.restablecer_controles();
             }
             else
                msgHelper.mostrar_CamposIncompletos();
        }

        //**************** MODIFICACION ROL ********************
        private void do_update()
        {
            if (helper.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
            {
                try
                {
                    Rol rol = obtener_rol_desde_form();

                    if (rol != null)
                    {
                        rolDao.modificar_rol(rol);
                        msgHelper.mostrar_aviso("Se ha modificado el rol", "Modificación de Rol");

                        actualizar_roles();
                        limpiar_campos();
                        restablecer_controles();
                    }
                    else
                    {
                        msgHelper.mostrar_error("No se ha podido modificar el rol, vuelva a intentarlo por favor", "Error en Modificación de Rol");
                    }
                }
                catch (Exception ex)
                {
                    msgHelper.mostrar_error(ex.Message, "Error en Modificación de Rol");
                }

                this.restablecer_controles();
            }
            else
                msgHelper.mostrar_CamposIncompletos();
        }

        //**************** BAJA ROL ********************
        private void do_delete()
        {
            try
            {
                if (id_rol_seleccionado > 0)
                {
                    rolDao.eliminar_rol(id_rol_seleccionado);
                    msgHelper.mostrar_aviso("Se ha eliminado el rol", "Baja de Rol");

                    actualizar_roles();
                    limpiar_campos();
                    restablecer_controles();
                }
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en Baja de Rol");
            }
        }
        #endregion

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
            uncheck_all();
        }

        private void actualizar_roles()
        {
            rolesGrid.DataSource = null;
            fill_roles_sistema();
        }

        private Rol obtener_rol_desde_form()
        {
            Rol rol = null;

            try
            {
                if (id_rol_seleccionado < 0)
                    return null;

                rol = new Rol()
                {
                    Id = id_rol_seleccionado,
                    Nombre = nombreTb.Text,
                    habilitado = habilitadoChk.Checked,
                    funcionalidades = this.obtener_fns_seleccionadas()
                };
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Rol");
            }

            return rol;
        }

        private List<Funcionalidad> obtener_fns_seleccionadas()
        {
            var fns = new List<Funcionalidad>();

            foreach (ItemControlHelper.itemListBox item in fnsChkList.CheckedItems)
            {
                fns.Add(new Funcionalidad(item.id_item, item.nombre_item));
            }

            return fns;
        }

        private void fnsChkList_EnabledChanged(object sender, EventArgs e)
        {
            if (fnsChkList.Enabled)
                fnsChkList.BackColor = Color.WhiteSmoke;
            else
                fnsChkList.BackColor = Color.LightGray;
        }

        private void limpiar_campos()
        {
            nombreTb.Text = string.Empty;
            fila_seleccionada = -1;
            id_rol_seleccionado = -1;
            habilitadoChk.Checked = false;
            rolesGrid.ClearSelection();
            rolesGrid.CurrentCell = null;
            uncheck_all();
        }

        private void fill_roles_sistema()
        {
            try
            {
                DataTable dt = rolDao.get_roles();
                if (dt.Rows.Count < 0)
                    MessageBox.Show("No se han encontrado roles en el sistema.", "ABM Rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    rolesGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Rol");
            }
        }

        private void fill_fns_sistema()
        {
            try
            {
                List<Funcionalidad> fns = rolDao.get_funcionalidades();

                if (fns.Count < 0) 
                {
                    msgHelper.mostrar_warning("No se han encontrado funcionalidades en el sistema.", "ABM Rol");
                    return;
                }

                foreach (Funcionalidad item in fns)
                {
                    fnsChkList.Items.Add(new ItemControlHelper.itemListBox(item.Nombre, item.Id));
                }
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Rol");
            }
        }

        private void rolesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            fila_seleccionada = e.RowIndex;

            try
            {
                restablecer_controles();
                id_rol_seleccionado = Convert.ToInt32(rolesGrid.Rows[e.RowIndex].Cells["ID"].Value);
                nombreTb.Text = rolesGrid.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                habilitadoChk.Checked = Convert.ToBoolean(rolesGrid.Rows[e.RowIndex].Cells["Habilitado"].Value);
                check_fns_rol();
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Rol");
            }
        }

        private void check_fns_rol()
        {
            try
            {
                List<Funcionalidad> fnsRol = rolDao.get_funcionalidades_by_Rol(id_rol_seleccionado);

                //iterate through items from fnsRol
                foreach (Funcionalidad f in fnsRol)
                {
                    //iterate through items from fnsChkList
                    for (int i = 0; i < fnsChkList.Items.Count; i++)
                    {
                        //get the item
                        var item = (ItemControlHelper.itemListBox)fnsChkList.Items[i];

                        if (item.id_item == f.Id)
                        {
                            //set "chequed" on "item"
                            fnsChkList.SetItemCheckState(i, CheckState.Checked);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msgHelper.mostrar_error(ex.Message, "Error en ABM Rol");
            }
        }

        private void uncheck_all()
        {
            for (int i = 0; i < fnsChkList.Items.Count; i++)
            {
                fnsChkList.SetItemCheckState(i, CheckState.Unchecked);
            }   
        }
        #endregion

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        
    }
}
