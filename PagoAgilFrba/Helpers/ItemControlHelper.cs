using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Helpers
{
    public class ItemControlHelper
    {
        public class itemComboBox
        {
            public string nombre_item { get; set; }
            public int id_item { get; set; }

            public itemComboBox(string _nombre, int _id)
            {
                nombre_item = _nombre;
                id_item = _id;
            }

            public override string ToString()
            {
                return nombre_item;
            }
        }

        public class itemListBox : itemComboBox
        {
            public itemListBox(string _nombre, int _id) : base(_nombre, _id) { }
        }

        public void descheckear_items(CheckedListBox chkList)
        {
            foreach (int i in chkList.CheckedIndices)
            {
                chkList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        public void select_in_combo(string name, ComboBox combo)
        {
            foreach (var item in combo.Items)
            {
                var i = item as itemComboBox;

                if (i.nombre_item == name)
                    combo.SelectedItem = item;
            }
        }
    }
}
