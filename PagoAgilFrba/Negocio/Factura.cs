using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Negocio
{
    public class Factura
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public int id_empresa { get; set; }
        public string nombre_empresa { get; set; }

        public UInt32 numero_factura { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public List<ItemFactura> items = new List<ItemFactura>();
        /// <summary>
        /// Pagada o Rendida
        /// </summary>
        public bool procesada { get; set; }
        public bool habilitada { get; set; }
        public double importe { get; set; }
    }

    public class FacturaSimpleViewModel
    {
        public int numeroFactura { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public double importe { get; set; }
    }

    public class FacturaSimpleSeleccionable : FacturaSimpleViewModel
    {
        public bool seleccionada { get; set; }
        public int Id { get; set; }
    }
}
