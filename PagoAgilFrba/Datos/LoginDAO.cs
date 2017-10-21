using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using PagoAgilFrba.Negocio;
using PagoAgilFrba.Helpers;

namespace PagoAgilFrba.Datos
{
    public class LoginDAO
    {
        private Usuario usuario_logueado = null;
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public int loguear_usuario(string _username, string _password)
        {
            int result = -1;

            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_login_check", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = _username;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = _password;

                SqlParameter returnParameter = cmd.Parameters.Add("@retorno", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                result = (int)cmd.Parameters["@retorno"].Value;
            }

            if (result > 0)
                usuario_logueado = this.obtener_usuario(_username, result);

            return result;
        }

        public Usuario obtener_usuario(string _username, int _id_usuario)
        {
            Usuario user = new Usuario(_id_usuario, _username, "");

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            using (SqlCommand sp = new SqlCommand("SistemaCaido.sp_get_roles_usuario", conn))
            {
                sp.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@idUsuario", SqlDbType.Decimal);
                param.Value = _id_usuario;
                param.Precision = 10;
                param.Scale = 0;

                sp.Parameters.Add(param);

                SqlDataReader lector2 = sp.ExecuteReader();

                if (lector2.HasRows)
                {
                    while (lector2.Read())
                    {
                        Rol rol = new Rol(Convert.ToInt32(lector2["IdRol"]), lector2["Nombre"].ToString());
                        rol.habilitado = Convert.ToBoolean(lector2["Habilitado"]);
                        user.roles.Add(rol);
                    }
                }

                lector2.Close();
            }

            conn.Close();
            conn.Dispose();

            return user;
        }

        public Usuario get_usuario_logueado()
        {
            return this.usuario_logueado;
        }
    }
}
