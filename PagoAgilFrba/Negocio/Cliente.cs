using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Negocio
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public UInt32 dni { get; set; }
        public string mail { get; set; }
        public UInt32 telefono { get; set; }
        public string direccion { get; set; }
        public int codigoPostal { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public bool habilitado { get; set; }
    }
}
