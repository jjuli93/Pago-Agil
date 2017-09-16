using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
