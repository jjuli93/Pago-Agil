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

        public List<FacturaSimpleSeleccionable> obtener_facturas_devolucion(int id_cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.GetFacturasParaDevolucionCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCliente", id_cliente);
                    conn.Open();

                    List<FacturaSimpleSeleccionable> facturas = new List<FacturaSimpleSeleccionable>();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int fieldFechaAlta = reader.GetOrdinal("FechaAlta");
                        int fieldFechaVencimiento = reader.GetOrdinal("FechaVencimiento");
                        int fieldImporte = reader.GetOrdinal("Importe");
                        int fieldNumeroFactura = reader.GetOrdinal("NumeroFactura");
                        int fieldIdFactura = reader.GetOrdinal("IdFactura");

                        facturas.Add(new FacturaSimpleSeleccionable()
                        {
                            fechaAlta = reader.GetDateTime(fieldFechaAlta),
                            fechaVencimiento = reader.GetDateTime(fieldFechaVencimiento),
                            importe = Convert.ToDouble(reader.GetDecimal(fieldImporte).ToString()),
                            numeroFactura = Convert.ToInt32(reader.GetDecimal(fieldNumeroFactura).ToString()),
                            Id = reader.GetInt32(fieldIdFactura),
                            seleccionada = false
                        });
                    }

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
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.RealizarDevolucion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //SistemaCaido.RealizarDevolucion 
                    //SistemaCaido.RealizarDevolucion (@IdCliente INT, @Motivo nvarchar(255), @Fecha DateTime, @ListaIdsFacturas SistemaCaido.listaIDs readonly)

                    cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = devolucion.Id_Cliente;
                    cmd.Parameters.Add("@Motivo", SqlDbType.NVarChar).Value = devolucion.Motivo;
                    cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = devolucion.Fecha_Devolucion;

                    var table = new DataTable();
                    table.Columns.Add("id", typeof(int));
                    devolucion.Facturas.ForEach(x => table.Rows.Add(x));

                    SqlParameter tablaIdsFacturas = new SqlParameter("@ListaIdsFacturas", SqlDbType.Structured)
                    {
                        TypeName = "SistemaCaido.listaIDs",
                        Value = table
                    };

                    cmd.Parameters.Add(tablaIdsFacturas);

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
