using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Negocio
{
    public class ItemFactura
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double monto { get; set; }
        public int cantidad { get; set; }
    }
}
