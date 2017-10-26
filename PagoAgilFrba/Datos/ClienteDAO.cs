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
    public class ClienteDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public bool crear_cliente(Cliente cliente)
        {
            if (cliente == null)
                return false;

            bool result = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_alta_cliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;
                    cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = cliente.apellido;
                    cmd.Parameters.Add("@fechanac", SqlDbType.Date).Value = cliente.fecha_nacimiento;
                    //cmd.Parameters.Add("@dni", SqlDbType.Decimal).Value = cliente.dni;
                    cmd.Parameters.AddWithValue("@dni", Convert.ToInt32(cliente.dni));
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = cliente.direccion;
                    //cmd.Parameters.Add("@codpost", SqlDbType.Decimal).Value = cliente.codigoPostal;
                    cmd.Parameters.AddWithValue("@codpost", Convert.ToInt32(cliente.codigoPostal));
                    //cmd.Parameters.Add("@telefono", SqlDbType.Decimal).Value = cliente.telefono;
                    cmd.Parameters.AddWithValue("@telefono", Convert.ToInt32(cliente.telefono));
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.mail;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error en Alta de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                //throw;
            }

            return result;
        }

        public bool modificar_cliente(Cliente cliente)
        {
            if (cliente == null)
                return false;

            bool result = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_update_cliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;
                    cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = cliente.apellido;
                    cmd.Parameters.Add("@DNI", SqlDbType.Decimal).Value = cliente.dni;
                    cmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = cliente.fecha_nacimiento;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = cliente.direccion;
                    cmd.Parameters.Add("@codPostal", SqlDbType.Decimal).Value = cliente.codigoPostal;
                    cmd.Parameters.Add("@telefono", SqlDbType.Decimal).Value = cliente.telefono;
                    //cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.mail;
                    cmd.Parameters.AddWithValue("@habilitado", cliente.habilitado);
                    cmd.Parameters.AddWithValue("@idcliente", cliente.id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error en Modificación de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                //throw;
            }

            return result;
        }

        public bool eliminar_cliente(int id_cliente)
        {
            bool result = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_baja_cliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idcliente", id_cliente);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                result = false;
                //throw;
            }

            return result;
        }

        public Cliente obtener_cliente_from_row(System.Windows.Forms.DataGridViewRow row)
        {
            Cliente cliente = new Cliente();
            cliente.id = Convert.ToInt32(row.Cells["ID"].Value);
            cliente.nombre = row.Cells["Nombre"].Value.ToString();
            cliente.apellido = row.Cells["Apellido"].Value.ToString();
            cliente.fecha_nacimiento = Convert.ToDateTime(row.Cells["Fecha_Nacimiento"].Value);
            cliente.dni = Convert.ToUInt32(row.Cells["DNI"].Value);
            cliente.direccion = row.Cells["Direccion"].Value.ToString();

            var cod_post = row.Cells["Codigo_Postal"].Value.ToString();

            if (string.IsNullOrEmpty(cod_post))
                cliente.codigoPostal = 0;
            else
                cliente.codigoPostal = Convert.ToInt32(cod_post);

            cliente.telefono = Convert.ToUInt32(row.Cells["Telefono"].Value);
            cliente.mail = row.Cells["Email"].Value.ToString();
            cliente.habilitado = Convert.ToBoolean(row.Cells["Habilitado"].Value);

            return cliente;
        }

        public DataTable buscar_clientes(string nombre, string apellido, string dni, string habilitados)
        {
            DataTable clientes = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.sp_get_clientes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (!string.IsNullOrWhiteSpace(nombre))
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                    else
                        cmd.Parameters.AddWithValue("@nombre", DBNull.Value);

                    if (!string.IsNullOrWhiteSpace(apellido))
                        cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
                    else
                        cmd.Parameters.AddWithValue("@apellido", DBNull.Value);

                    if (!string.IsNullOrWhiteSpace(dni))
                    {
                        Int32 dni_num = 0;

                        if (Int32.TryParse(dni, out dni_num))
                            cmd.Parameters.AddWithValue("@dni", dni_num);
                        else
                            cmd.Parameters.AddWithValue("@dni", DBNull.Value);
                    }
                    else
                        cmd.Parameters.AddWithValue("@dni", DBNull.Value);

                    if (habilitados == "SI")
                        cmd.Parameters.AddWithValue("@habilitado", 1);
                    else
                        cmd.Parameters.AddWithValue("@habilitado", DBNull.Value);

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    clientes.Load(lector);

                    lector.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return clientes;
        }
    }
}
