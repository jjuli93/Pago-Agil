using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Negocio
{
    public class Factura
    {
        int id;
        int id_cliente;
        string nombre_cliente;
        int id_empresa;
        string nombre_empresa;
        UInt32 numero_factura;
        DateTime fecha_alta;
        DateTime fecha_vencimiento;
        List<ItemFactura> items = new List<ItemFactura>();
        /// <summary>
        /// Pagada o Rendida
        /// </summary>
        bool procesada;
    }
}
