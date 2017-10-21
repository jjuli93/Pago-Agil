using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Negocio
{
    public class Funcionalidad
    {
        public int Id;
        public string Nombre;

        public Funcionalidad() { }

        public Funcionalidad(int _id, string _nombre)
        {
            this.Id = _id;
            this.Nombre = _nombre;
        }

        public Form get_form()
        {
            Form frm = null;

            switch (this.Id)
            {
                case 1:
                    frm = new PagoAgilFrba.AbmRol.FrmABMRol();
                    break;
                case 2:
                    //not defined
                    break;
                case 3:
                    frm = new PagoAgilFrba.AbmCliente.FrmABMCliente();
                    break;
                case 4:
                    frm = new PagoAgilFrba.AbmEmpresa.FrmABMEmpresa();
                    break;
                case 5:
                    frm = new PagoAgilFrba.AbmSucursal.FrmABMSucursal();
                    break;
                case 6:
                    frm = new PagoAgilFrba.AbmFactura.FrmABMFactura();
                    break;
                case 7:
                    frm = new PagoAgilFrba.RegistroPago.FrmRegistroPagoFactura();
                    break;
                case 8:
                    frm = new PagoAgilFrba.Rendicion.FrmRendicionFacturas();
                    break;
                case 9:
                    frm = new PagoAgilFrba.ListadoEstadistico.FrmTopEstadistico();
                    break;
                default:
                    break;
            }

            return frm;
        }
    }
}
