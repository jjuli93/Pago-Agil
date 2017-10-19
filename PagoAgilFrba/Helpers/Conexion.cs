using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Configuration;

namespace PagoAgilFrba.Helpers
{
    public class Conexion
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["GD2C2017"].ConnectionString;
        private static DateTime fecha_default = Convert.ToDateTime(ConfigurationManager.AppSettings["current_date"]);

        public string getConnectionString()
        {
            return connectionString;
        }

        public DateTime getFecha()
        {
            return fecha_default;
        }
    }
}
