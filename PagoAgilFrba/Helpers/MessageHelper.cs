using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Helpers
{
    public class MessageHelper
    {
        public void mostrar_error(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult mostrar_confirmacion(string msg, string title)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void mostrar_aviso(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void mostrar_warning(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void mostrar_CamposIncompletos()
        {
            MessageBox.Show("Por favor ingrese todos los datos obligatorios", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void mostrar_FilaNoSeleccionada()
        {
            MessageBox.Show("Seleccione previamente un registro", "PagoAgilFrba App", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
