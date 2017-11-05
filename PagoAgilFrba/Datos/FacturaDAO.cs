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
    public class FacturaDAO
    {
        private string connString = Singleton<Conexion>.Instance.getConnectionString();

        public void crear_factura(Factura factura)
        {
            if (factura == null)
                throw new Exception("Factura nula en crear_factura", new NullReferenceException());

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.AltaFactura", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;                  
                    //[SistemaCaido].AltaFactura
                    //(@IdCliente int, @IdEmpresa int, @NumeroFactura numeric(18,0), @FechaVencimiento datetime, 
                    //@Items [SistemaCaido].Items readonly)

                    cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = factura.id_cliente;
                    cmd.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = factura.id_empresa;
                    var p_nro_fact = cmd.Parameters.Add("@NumeroFactura", SqlDbType.Decimal);
                    p_nro_fact.Precision = 18;
                    p_nro_fact.Scale = 0;
                    p_nro_fact.Value = (decimal)factura.numero_factura;
                    cmd.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime).Value = factura.fecha_vencimiento;

//                   CREATE TYPE [SistemaCaido].[Items] AS TABLE(
//    [Descripcion] varchar(250) NULL,
//    [Monto] [numeric](18, 2) NULL,
//    [Cantidad] [numeric](18, 0) NULL
//)
                    var table = new DataTable();

                    table.Columns.Add("Descripcion", typeof(string));
                    table.Columns.Add("Monto", typeof(decimal));
                    table.Columns.Add("Cantidad", typeof(decimal));

                    foreach (ItemFactura item in factura.items)
                    {
                        table.Rows.Add(item.descripcion, item.monto, item.cantidad);
                    }

                    var plist = new SqlParameter("@Items", SqlDbType.Structured);
                    plist.TypeName = "SistemaCaido.Items";
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

        public void modificar_factura(Factura factura)
        {
            if (factura == null)
                throw new Exception("Factura nula en modificar_factura", new NullReferenceException());

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.ModificacionFactura", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
//                    create procedure [SistemaCaido].[ModificacionFactura]
//(@IdFactura int, @IdCliente int, @IdEmpresa int, @NumeroFactura int, @FechaAlta datetime, @FechaVencimiento datetime, @Items SistemaCaido.Items readonly)

                    cmd.Parameters.Add("@IdFactura", SqlDbType.Int).Value = factura.id;
                    cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = factura.id_cliente;
                    cmd.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = factura.id_empresa;
                    cmd.Parameters.Add("@NumeroFactura", SqlDbType.Int).Value = factura.numero_factura;
                    cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime).Value = factura.fecha_alta;
                    cmd.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime).Value = factura.fecha_vencimiento;

                    var table = new DataTable();

                    table.Columns.Add("Descripcion", typeof(string));
                    table.Columns.Add("Monto", typeof(decimal));
                    table.Columns.Add("Cantidad", typeof(decimal));

                    foreach (ItemFactura item in factura.items)
                    {
                        table.Rows.Add(item.descripcion, item.monto, item.cantidad);
                    }

                    var plist = new SqlParameter("@Items", SqlDbType.Structured);
                    plist.TypeName = "SistemaCaido.Items";
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

        public void eliminar_factura(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.BajaFactura", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //[SistemaCaido].[BajaFactura](@IdFactura int)

                    cmd.Parameters.Add("@IdFactura", SqlDbType.Int).Value = id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable buscar_facturas(string nro_fact, string cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.BuscarFacturas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //SistemaCaido.BuscarFacturas (@numeroFactura int, @idCliente int)

                    if (string.IsNullOrWhiteSpace(nro_fact))
                        cmd.Parameters.AddWithValue("@numeroFactura", DBNull.Value);
                    else
                        cmd.Parameters.Add("@numeroFactura", SqlDbType.Int).Value = Convert.ToInt32(nro_fact);

                    if (string.IsNullOrWhiteSpace(cliente))
                        cmd.Parameters.AddWithValue("@idCliente", DBNull.Value);
                    else
                        cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = Convert.ToInt32(cliente);
                        

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    DataTable facturas = new DataTable();

                    facturas.Load(lector);

                    lector.Close();

                    return facturas;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public bool verificar_factura(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.FacturaPuedeSerModificada", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //SistemaCaido.FacturaPuedeSerModificada(@IdFactura int)

                    cmd.Parameters.Add("@IdFactura", SqlDbType.Int).Value = id;

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();
                    var valueLector = 0;

                    if (lector.HasRows)
                    {
                        lector.Read();

                        valueLector = Convert.ToInt32(lector[0]);
                    }

                    lector.Close();

                    if (valueLector == 1)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable obtener_items_factura(int id_factura)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("SistemaCaido.GetItemsFactura", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //SistemaCaido.GetItemsFactura(@IdFactura int)

                    cmd.Parameters.Add("@IdFactura", SqlDbType.Int).Value = id_factura;

                    conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    DataTable items = new DataTable();

                    items.Load(lector);

                    lector.Close();

                    return items;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
