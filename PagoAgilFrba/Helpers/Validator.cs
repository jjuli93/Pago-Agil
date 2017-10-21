using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Helpers
{
    public class Validator
    {
        public bool validate_textBox(TextBox tb)
        {
            return !String.IsNullOrWhiteSpace(tb.Text);
        }

        public bool validate_comboBox(ComboBox cb)
        {
            return !String.IsNullOrWhiteSpace(cb.Text) && cb.SelectedItem != null;
        }

        public bool validate_chkList(CheckedListBox chkList)
        {
            return chkList.CheckedItems.Count > 0;
        }

        public bool validate_dateTimePicker(DateTimePicker dtp)
        {
            return (dtp.Value.ToString() != "");
        }
    }
}
