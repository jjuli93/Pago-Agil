using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Negocio
{
    public class PagoFactura
    {
        int id;
        int nro_factura;
        DateTime fecha_cobro;
        string nombre_empresa;
        int id_empresa;
        string nombre_cliente;
        int id_cliente;
        DateTime fecha_vencimiento;
        decimal importe;
        string sucursal;
        bool habilitado;

        public void set_empresa(int id, string nombre)
        {
            this.id_empresa = id;
            this.nombre_empresa = nombre;
        }

        public void set_cliente(int id, string nombre)
        {
            this.id_cliente = id;
            this.nombre_cliente = nombre;
        }

        public PagoFactura obtener_pago(DataGridViewRow row)
        {
            PagoFactura pago = null;

            try
            {
                pago = new PagoFactura();

                pago.nro_factura = (int)row.Cells["Nro Factura"].Value;
                pago.fecha_cobro = Convert.ToDateTime(row.Cells["Fecha cobro"].Value);
                pago.nombre_empresa = row.Cells["Empresa"].Value.ToString();
                pago.nombre_cliente = row.Cells["Cliente"].Value.ToString();
                pago.fecha_vencimiento = Convert.ToDateTime(row.Cells["Vencimiento"].Value);
                pago.sucursal = row.Cells["Sucursal"].Value.ToString();
                pago.importe = Convert.ToDecimal(row.Cells["Importe"].Value);
            }
            catch (Exception)
            {
                pago = null;
            }

            return pago;
        }
    }
}
