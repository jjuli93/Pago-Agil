using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Negocio
{
    public class Devolucion
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha_Devolucion { get; set; }
        public string Motivo { get; set; }
        public List<int> Facturas { get; set; }
    }
}
