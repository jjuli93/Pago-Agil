using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using PagoAgilFrba.Helpers;

namespace PagoAgilFrba.Datos
{
    public class TopDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public DataTable consultar_listado(int year, int trimestre, int listado_id)
        {
            DataTable dt = new DataTable();

            string sp = obtener_sp(listado_id);

            if (sp != string.Empty)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    using (SqlCommand cmd = new SqlCommand(sp, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Anio", year);
                        cmd.Parameters.AddWithValue("@trimestre", trimestre);

                        conn.Open();
                        SqlDataReader lector = cmd.ExecuteReader();

                        dt.Load(lector);

                        lector.Close();
                    }
                }
                catch (SqlException)
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
                    sp = "SistemaCaido.EmpresasConMayorPorcentajeFacturasCobradas";
                    break;
                case 2:
                    sp = "[SistemaCaido].[EmpresasConMayorMontoRendido]";
                    break;
                case 3:
                    sp = "[SistemaCaido].[ClientesConMasPagos]";
                    break;
                case 4:
                    sp = "SistemaCaido.ClientesConMayorPorcentajeFacturasPagadas";
                    break;
                default:
                    break;
            }

            return sp;
        }
    }
}
