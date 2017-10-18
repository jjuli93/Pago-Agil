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
        int id;
        string nombre;
        UInt32 cuit;
        string direccion;
        ItemControlHelper.itemComboBox rubro;
        bool habilitado;
    }
}
