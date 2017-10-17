using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PagoAgilFrba.Datos
{
    public class TopDAO
    {
        public DataTable consultar_listado(int year, int trimestre, int listado_id)
        {
            DataTable dt = new DataTable();

            string sp = obtener_sp(listado_id);

            if (sp != string.Empty)
            {
                try
                {

                }
                catch (Exception)
                {
                    throw;
                }
            }

            return dt;
        }

        private string obtener_sp(int id)
        {
            string sp = string.Empty;

            switch (id)
            {
                case 1:
                    sp = "";
                    break;
                case 2:
                    sp = "";
                    break;
                case 3:
                    sp = "";
                    break;
                case 4:
                    sp = "";
                    break;
                default:
                    break;
            }

            return sp;
        }
    }
}
