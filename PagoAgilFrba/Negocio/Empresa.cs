using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Helpers;

namespace PagoAgilFrba.Negocio
{
    public class Empresa
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public UInt32 cuit { get; set; }
        public string direccion { get; set; }
        public ItemControlHelper.itemComboBox rubro { get; set; }
        public bool habilitado { get; set; }
    }
}
