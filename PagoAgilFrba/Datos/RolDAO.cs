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
                //throw;
            }

            return roles;
        }

        public bool modificar_rol(Rol rol_modificado)
        {
            bool result = true;

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
                    plist.TypeName = "ddg.listaIDs";
                    plist.Value = table;

                    cmd.Parameters.Add(plist);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error en Modificación Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                //throw;
            }

            return result;
        }

        public bool eliminar_rol(int id_rol)
        {
            bool result = true;

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

            return result;
        }

        internal bool crear_rol(string nombre_rol, List<ItemControlHelper.itemListBox> funcionalidades)
        {
            bool result = true;

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

                    foreach (ItemControlHelper.itemListBox item in funcionalidades)
                    {
                        table.Rows.Add(item.id_item);
                    }

                    var plist = new SqlParameter("@listaFuncionalidades", SqlDbType.Structured);
                    plist.TypeName = "ddg.listaIDs";
                    plist.Value = table;

                    cmd.Parameters.Add(plist);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error en Alta Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                //throw;
            }

            return result;
        }

        public Rol obtenerRol(System.Windows.Forms.DataGridViewRow row)
        {
            if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                return null;

            Rol rol = new Rol(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());

            rol.habilitado = Convert.ToBoolean(row.Cells[2].Value);

            rol.funcionalidades = get_funcionalidades_by_Rol(rol.Id);

            return rol;
        }

        public List<Funcionalidad> get_funcionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

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

            return funcionalidades;
        }

        public List<Funcionalidad> get_funcionalidades_by_Rol(int id_rol)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

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

                        if (funID == 2 & funDesc == "Registro de Usuario")
                            continue;

                        Funcionalidad f = new Funcionalidad(funID, funDesc);

                        funcionalidades.Add(f);
                    }
                }

                lector.Close();
            }

            return funcionalidades;
        }
    }
}
