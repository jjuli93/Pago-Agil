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
    public class EmpresaDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public void crear_empresa(Empresa empresa)
        {
            if (empresa == null)
                throw new Exception("Empresa nula en crear_empresa", new NullReferenceException());

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.AltaEmpresa", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //@Nombre nvarchar(255), @CUIT nvarchar(50), @Direccion nvarchar(255), @IdRubro int

                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = empresa.nombre;
                    cmd.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = empresa.cuit;
                    cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = empresa.direccion;
                    cmd.Parameters.Add("@IdRubro", SqlDbType.Int).Value = empresa.rubro.id_item;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void modificar_empresa(Empresa empresa)
        {
            if (empresa == null)
                throw new Exception("Empresa nula en modificar_empresa", new NullReferenceException());

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.ModificacionEmpresa", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //(@IdEmpresa int, @Nombre nvarchar(255), @CUIT nvarchar(50), 
                    //@Direccion nvarchar(255), @IdRubro int, @Habilitada char)

                    cmd.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = empresa.id;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = empresa.nombre;
                    cmd.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = empresa.cuit;
                    cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = empresa.direccion;
                    cmd.Parameters.Add("@IdRubro", SqlDbType.NVarChar).Value = empresa.rubro.id_item;
                    cmd.Parameters.Add("@Habilitada", SqlDbType.Bit).Value = empresa.habilitado;
                    //cmd.Parameters.Add("@Habilitada", SqlDbType.Char).Value = "Y";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void eliminar_empresa(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.BajaEmpresa", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //[SistemaCaido].[BajaEmpresa](@IdEmpresa int)

                    cmd.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void setRubrosCB(ComboBox combo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.GetRubros", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            combo.Items.Add(new ItemControlHelper.itemComboBox(lector["Nombre"].ToString(), Convert.ToInt32(lector["IdRubro"])));
                        }
                    }

                    lector.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable buscar_empresas(string nombre, string cuit, int rubro)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.BuscarEmpresas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //(@Nombre nvarchar(255), @CUIT nvarchar(50),  @IdRubro int)

                    if (!string.IsNullOrWhiteSpace(nombre))
                        cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
                    else
                        cmd.Parameters.AddWithValue("@Nombre", DBNull.Value);

                    if (!string.IsNullOrWhiteSpace(cuit))
                        cmd.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = cuit;
                    else
                        cmd.Parameters.AddWithValue("@CUIT", DBNull.Value);

                    if (rubro > 0)
                        cmd.Parameters.Add("@IdRubro", SqlDbType.Int).Value = rubro;
                    else
                        cmd.Parameters.AddWithValue("@IdRubro", DBNull.Value);

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    DataTable empresas = new DataTable();

                    empresas.Load(lector);

                    lector.Close();

                    return empresas;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void setEmpresasHabilitadasCB(ComboBox combo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.GetEmpresasHabilitadas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int fieldId = reader.GetOrdinal("IdEmpresa");
                        int fieldNombre = reader.GetOrdinal("Nombre");

                        string nombre = reader.GetString(fieldNombre);
                        int id = reader.GetInt32(fieldId);
                        ItemControlHelper.itemComboBox item = new ItemControlHelper.itemComboBox(nombre, id);

                        combo.Items.Add(item);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
