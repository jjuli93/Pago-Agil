using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Negocio
{
    public class Sucursal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string codPostal { get; set; }
        public bool habilitado { get; set; }
    }
}
