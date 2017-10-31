﻿using System;
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
    public class PagoDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();


        public List<FacturaSimpleViewModel> GetFacturasClienteParaPago(int idCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.GetFacturasClienteParaPago", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    conn.Open();

                    List<FacturaSimpleViewModel> facturas = new List<FacturaSimpleViewModel>();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int fieldFechaAlta = reader.GetOrdinal("FechaAlta");
                        int fieldFechaVencimiento = reader.GetOrdinal("FechaVencimiento");
                        int fieldImporte = reader.GetOrdinal("Importe");
                        int fieldNumeroFactura = reader.GetOrdinal("NumeroFactura");

                        facturas.Add(new FacturaSimpleViewModel()
                        {
                            fechaAlta = reader.GetDateTime(fieldFechaAlta),
                            fechaVencimiento = reader.GetDateTime(fieldFechaVencimiento),
                            importe = Convert.ToDouble(reader.GetDecimal(fieldImporte).ToString()),
                            numeroFactura = Convert.ToInt32(reader.GetDecimal(fieldNumeroFactura).ToString())
                        });
                    }

                    return facturas;
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }

        public List<ItemControlHelper.itemComboBox> GetMediosDePago()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.GetMediosDePago", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    List<ItemControlHelper.itemComboBox> mediosDePago = new List<ItemControlHelper.itemComboBox>();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int fieldId = reader.GetOrdinal("IdMedioPago");
                        int fieldNombre = reader.GetOrdinal("Nombre");

                        string nombre = reader.GetString(fieldNombre);
                        int id = reader.GetInt32(fieldId);

                        mediosDePago.Add(new ItemControlHelper.itemComboBox(nombre, id));
                    }

                    return mediosDePago;
                }
            }
            catch (SqlException e)
            {
                throw;
            }
        }


        public void RealizarPago(List<int> idsFacturas, int idCliente, int idSucursal, int idMedioDePago)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.RegistrarPago", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("id", typeof(string));
                    idsFacturas.ForEach(x => dt.Rows.Add(x));

                    SqlParameter tablaIdsFacturas = new SqlParameter("@IdsFacturas", SqlDbType.Structured)
                    {
                        TypeName = "SistemaCaido.listaIDs",
                        Value = dt
                    };

                    cmd.Parameters.Add(tablaIdsFacturas);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@Sucursal", idSucursal);
                    cmd.Parameters.AddWithValue("@MedioPago", idMedioDePago);


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
