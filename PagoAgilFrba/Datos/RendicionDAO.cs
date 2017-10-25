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
    public class RendicionDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public RendicionViewModel getDatosRendicion (int idEmpresa, DateTime fecha)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.GetDatosRendicion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpresa",idEmpresa);
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                    conn.Open();

                    RendicionViewModel rendicion = new RendicionViewModel();
                    rendicion.facturas = new List<FacturaSimpleViewModel>();

                     SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        int fieldFechaAlta = reader.GetOrdinal("FechaAlta");
                        int fieldFechaVencimiento = reader.GetOrdinal("FechaVencimiento");
                        int fieldImporte = reader.GetOrdinal("Importe");
                        int fieldNumeroFactura = reader.GetOrdinal("NumeroFactura");

                        rendicion.facturas.Add( new FacturaSimpleViewModel()
                        { 
                            fechaAlta = reader.GetDateTime(fieldFechaAlta),
                            fechaVencimiento = reader.GetDateTime(fieldFechaVencimiento),
                            importe = Convert.ToDouble(reader.GetDecimal(fieldImporte).ToString()),
                            numeroFactura  = Convert.ToInt32(reader.GetDecimal(fieldNumeroFactura).ToString())                   
                        });
                    }
                    if(reader.NextResult())
                    {
                        while(reader.Read())
                        {
                            rendicion.importeTotal = Convert.ToDouble(reader["Importe_Total"].ToString());
                            rendicion.importeEmpresa = Convert.ToDouble(reader["Importe_Empresa"].ToString());
                        }
                    }
                    if(reader.NextResult())
                    {
                        while(reader.Read())
                        {
                            rendicion.porcentajeComision = Convert.ToDouble(reader["Porcentaje"].ToString());
                        }
                    }

                    return rendicion;
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }


        public void RealizarRendicion(int idEmpresa, DateTime fecha)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.RealizarRendicion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa);
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                    conn.Open();

                    RendicionViewModel rendicion = new RendicionViewModel();
                    rendicion.facturas = new List<FacturaSimpleViewModel>();

                    cmd.ExecuteNonQuery();                    
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }
    }
}
