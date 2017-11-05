using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoAgilFrba.Negocio;
using PagoAgilFrba.Helpers;

namespace PagoAgilFrba.Datos
{
    public class DevolucionDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public DataTable obtener_facturas_devolucion(int id_cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.BuscarFacturas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //SistemaCaido.GetFacturasParaDevolucionCliente(@IdCliente INT)

                    cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = id_cliente;

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    DataTable facturas = new DataTable();

                    facturas.Load(lector);

                    lector.Close();

                    return facturas;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void realizar_devolucion(Devolucion devolucion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.BuscarFacturas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //SistemaCaido.RealizarDevolucion 
                    //(@IdCliente INT, @Motivo nvarchar(255), @Fecha DateTime, @ListaIdsFacturas SistemaCaido.listaIDs readonly)

                    cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = devolucion.Id_Cliente;
                    cmd.Parameters.Add("@Motivo", SqlDbType.NVarChar).Value = devolucion.Motivo;
                    cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = devolucion.Fecha_Devolucion;

                    var table = new DataTable();

                    table.Columns.Add("id", typeof(int));

                    foreach (Factura item in devolucion.Facturas)
                    {
                        table.Rows.Add(item.id);
                    }

                    var plist = new SqlParameter("@ListaIdsFacturas", SqlDbType.Structured);
                    plist.TypeName = "SistemaCaido.listaIDs";
                    plist.Value = table;

                    cmd.Parameters.Add(plist);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
