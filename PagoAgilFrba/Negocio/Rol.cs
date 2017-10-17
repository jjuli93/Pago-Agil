using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Negocio
{
    public class Rol
    {
        public List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
        public string Nombre;
        public int Id;
        public bool habilitado;

        public Rol() { }

        public Rol(int _id, string _nombre)
        {
            this.Id = _id;
            this.Nombre = _nombre;
        }
    }
}
