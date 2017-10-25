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

        public bool crear_empresa(Empresa empresa)
        {
            bool result = true;

            if (empresa == null)
                return false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;
                    

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error en Alta de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                //throw;
            }

            return result;
        }

        public bool modificar_empresa(Empresa empresa)
        {
            bool result = true;

            if (empresa == null)
                return false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;


                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error en Alta de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                //throw;
            }

            return result;
        }

        public bool eliminar_empresa(int id)
        {
            bool result = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;


                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error en Alta de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                //throw;
            }

            return result;
        }


        public List<ItemControlHelper.itemComboBox> getEmpresasHabilitadasCB()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.GetEmpresasHabilitadas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<ItemControlHelper.itemComboBox> listaItemsCB = new List<ItemControlHelper.itemComboBox>();
                    while (reader.Read())
                    {
                        int fieldId = reader.GetOrdinal("IdEmpresa");
                        int fieldNombre = reader.GetOrdinal("Nombre");

                        string nombre = reader.GetString(fieldNombre);
                        int id = reader.GetInt32(fieldId);
                        ItemControlHelper.itemComboBox item = new ItemControlHelper.itemComboBox(nombre, id);
                        
                        listaItemsCB.Add(item);
                    }

                    return listaItemsCB;
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

    }
}
