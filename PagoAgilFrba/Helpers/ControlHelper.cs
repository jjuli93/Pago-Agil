using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PagoAgilFrba.Helpers
{
    public class ControlHelper
    {
        Validator validator = Singleton<Validator>.Instance;
        ItemControlHelper itemHelper = Singleton<ItemControlHelper>.Instance;

        /// <summary>
        /// Cambia la visibilidad de una lista de controles
        /// </summary>
        /// <param name="controles"></param>
        /// <param name="visible"></param>
        public void visualizar_controles(List<Control> controles, bool visible)
        {
            controles.ForEach(c => c.Visible = visible);
        }

        /// <summary>
        /// Cambia la propiedad 'habilitado' de una lista de controles
        /// </summary>
        /// <param name="controles"></param>
        /// <param name="habilitado"></param>
        public void habilitar_controles(List<Control> controles, bool habilitado)
        {
            controles.ForEach(c => c.Enabled = habilitado);
        }

        /// <summary>
        /// Verifica si un campo es valido
        /// </summary>
        /// <param name="c">Control</param>
        /// <param name="e">ErrorProvider</param>
        /// <returns></returns>
        public bool campo_cumple(Control c, ErrorProvider e)
        {
            bool cumple = false;

            var control_type = c.GetType();

            switch (control_type.Name)
            {
                case "TextBox":
                    if (!(cumple = validator.validate_textBox(c as TextBox)))
                        e.SetError(c, "Ingrese los datos requeridos");
                    break;
                case "CheckedListBox":
                    if (!(cumple = validator.validate_chkList(c as CheckedListBox)))
                        e.SetError(c, "Debe seleccionar al menos uno");
                    break;
                case "ComboBox":
                    if (!(cumple = validator.validate_comboBox(c as ComboBox)))
                        e.SetError(c, "Debe seleccionar uno");
                    break;
                default:
                    break;
            }

            return cumple;
        }

        /// <summary>
        /// Verifica si todos los campos de una lista son validos
        /// </summary>
        /// <param name="campos">List of Control</param>
        /// <param name="e">ErrorProvider</param>
        /// <returns></returns>
        public bool cumple_campos_obligatorios(List<Control> campos, ErrorProvider e)
        {
            return campos.All(c => campo_cumple(c, e));
        }

        /// <summary>
        /// Limpia el contenido de un Control y de sus controles hijos
        /// </summary>
        /// <param name="father">Control</param>
        public void limpiar_controles(Control father)
        {
            foreach (Control c in father.Controls)
            {
                var control_type = c.GetType();

                switch (control_type.Name)
                {
                    case "TextBox":
                        c.Text = string.Empty;
                        break;
                    case "CheckedListBox":
                        var chkList = c as CheckedListBox;
                        chkList.SelectedIndices.Clear();
                        chkList.SelectedItems.Clear();
                        itemHelper.descheckear_items(chkList);
                        break;
                    case "ComboBox":
                        var combo = c as ComboBox;
                        combo.SelectedItem = null;
                        combo.SelectedIndex = -1;
                        combo.Text = string.Empty;
                        break;
                    default:
                        break;
                }

                this.limpiar_controles(c);
            }
        }

        /// <summary>
        /// Limpia el mensaje de error de cada campo
        /// </summary>
        /// <param name="campos">List of Control</param>
        /// <param name="e">ErrorProvider</param>
        public void limpiar_errorProvider(List<Control> campos, ErrorProvider e)
        {
            campos.ForEach(c => e.SetError(c, ""));
        }

        public void cerrar_app()
        {
            if (MessageBox.Show("¿Desea salir de PagoAgil?", "PagoAgil FRBA App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void cerrar_sesion()
        {
            if (MessageBox.Show("¿Cerrar sesión?", "PagoAgil FRBA App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        public void cambiar_color_labels(List<Label> labels, Color color)
        {
            labels.ForEach(l => l.ForeColor = color);
        }

        public void limpiar_tabla(DataGridView tabla)
        {
            //TODO: Ver el tema de la nulidad de la tabla y su datasource
            tabla.ClearSelection();
            tabla.Rows.Clear();
            tabla.DataSource = null;
        }
    }
}
