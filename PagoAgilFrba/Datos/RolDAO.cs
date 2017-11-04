using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using PagoAgilFrba.Negocio;
using System.Windows.Forms;
using PagoAgilFrba.Helpers;

namespace PagoAgilFrba.Datos
{
    public class RolDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public DataTable get_roles()
        {
            DataTable roles = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_get_roles", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    roles = new DataTable();

                    roles.Load(lector);

                    lector.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return roles;
        }

        public void crear_rol(string nombre_rol, List<Funcionalidad> funcionalidades)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_alta_rol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_rol;
                    cmd.Parameters.Add("@habilitado", SqlDbType.Bit).Value = 1;

                    var table = new DataTable();

                    table.Columns.Add("id", typeof(int));

                    foreach (Funcionalidad item in funcionalidades)
                    {
                        table.Rows.Add(item.Id);
                    }

                    var plist = new SqlParameter("@listaFuncionalidades", SqlDbType.Structured);
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

        public void modificar_rol(Rol rol_modificado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_update_rol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", rol_modificado.Id);
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = rol_modificado.Nombre;
                    cmd.Parameters.Add("@habilitado", SqlDbType.Bit).Value = Convert.ToInt32(rol_modificado.habilitado);

                    var table = new DataTable();

                    table.Columns.Add("id", typeof(int));

                    foreach (var item in rol_modificado.funcionalidades)
                    {
                        table.Rows.Add(item.Id);
                    }

                    var plist = new SqlParameter("@listaFuncionalidades", SqlDbType.Structured);
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

        public void eliminar_rol(int id_rol)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_baja_rol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id_rol);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Crea un objeto Rol a partir de una fila
        /// </summary>
        /// <param name="row">DataGridViewRow</param>
        /// <returns>Rol</returns>
        public Rol obtenerRol(System.Windows.Forms.DataGridViewRow row)
        {
            Rol rol = null;

            try
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                    return null;

                rol = new Rol(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());

                rol.habilitado = Convert.ToBoolean(row.Cells[2].Value);

                rol.funcionalidades = get_funcionalidades_by_Rol(rol.Id);
            }
            catch (Exception)
            {
                throw;
            }

            return rol;
        }

        /// <summary>
        /// Obtiene todas las funcionalidades del sistema
        /// </summary>
        /// <returns></returns>
        public List<Funcionalidad> get_funcionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_get_funcionalidades", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            Funcionalidad f = new Funcionalidad(Convert.ToInt32(lector["IdFuncionalidad"]), lector["Nombre"].ToString());

                            funcionalidades.Add(f);
                        }
                    }

                    lector.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return funcionalidades;
        }

        /// <summary>
        /// Obtiene las funcionalidades habilitadas de un rol
        /// </summary>
        /// <param name="id_rol"></param>
        /// <returns></returns>
        public List<Funcionalidad> get_funcionalidades_by_Rol(int id_rol)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_get_funcionalidades_rol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idRol", id_rol);

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    var funID = 0;
                    var funDesc = "";

                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            funID = Convert.ToInt32(lector["IdFuncionalidad"]);
                            funDesc = lector["Nombre"].ToString();

                            Funcionalidad f = new Funcionalidad(funID, funDesc);

                            funcionalidades.Add(f);
                        }
                    }

                    lector.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return funcionalidades;
        }
    }
}
