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
    public class SucursalDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public void crear_sucursal(Sucursal sucursal)
        {
            if (sucursal == null)
                throw new Exception("Sucursal nula en crear_sucursal", new NullReferenceException());

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.AltaSucursal", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //[SistemaCaido].[AltaSucursal](@Nombre nvarchar(255), @Direccion nvarchar(255), @CodigoPostal varchar(4))

                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = sucursal.nombre;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = sucursal.nombre;
                    cmd.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = sucursal.nombre;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void modificar_sucursal(Sucursal sucursal)
        {
            if (sucursal == null)
                throw new Exception("Sucursal nula en modificar_sucursal", new NullReferenceException());

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.ModificacionSucursal", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
        //(@IdSucursal int, @Nombre nvarchar(255), @Direccion nvarchar(255), @CodigoPostal varchar(4), @Habilitada char)

                    cmd.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = sucursal.id;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = sucursal.nombre;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = sucursal.nombre;
                    cmd.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = sucursal.codPostal;

                    if (sucursal.habilitado)
                        cmd.Parameters.Add("@Habilitada", SqlDbType.Bit).Value = 1;
                    else
                        cmd.Parameters.Add("@Habilitada", SqlDbType.Bit).Value = 0;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public void eliminar_sucursal(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.BajaSucursal", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public DataTable buscar_sucursales(string nombre, string direccion, string cp)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.BuscarSucursales", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //@Nombre nvarchar(255), @CodigoPostal nvarchar(4),  @Direccion nvarchar(255)

                    if (!string.IsNullOrWhiteSpace(nombre))
                        cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
                    else
                        cmd.Parameters.AddWithValue("@Nombre", DBNull.Value);

                    if (!string.IsNullOrWhiteSpace(cp))
                        cmd.Parameters.Add("@CodigoPostal", SqlDbType.NVarChar).Value = cp;
                    else
                        cmd.Parameters.AddWithValue("@CodigoPostal", DBNull.Value);

                    if (!string.IsNullOrWhiteSpace(direccion))
                        cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = direccion;
                    else
                        cmd.Parameters.AddWithValue("@Direccion", DBNull.Value);

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    DataTable sucursales = new DataTable();

                    sucursales.Load(lector);

                    lector.Close();

                    return sucursales;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
