using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Negocio
{
    public class RendicionViewModel
    {
        public List<FacturaSimpleViewModel> facturas {get; set;}
        public double importeTotal { get; set; }
        public double importeEmpresa { get; set; }
        public double porcentajeComision { get; set; }
       
    }
}
