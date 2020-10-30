using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
namespace CapaDatos
{
    public class detalleFactura_da
    {
        static SqlConnection con = conexion.getConexion();
        public static Boolean registrarDetalleFactura(int idProducto, int cantidad, string precio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_insertarDetalleFactura", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precio", Convert.ToDouble(precio));
                con.Open();
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public static List<detalleFactura> consultarDetalleRegistrado(string serieFactura, string numFactura)
        {
            List<detalleFactura> lista = new List<detalleFactura>();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_consultarDetalleRegistrado", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@serieFactura", serieFactura);
                cmd.Parameters.AddWithValue("@numFactura", numFactura);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                detalleFactura d;
                while (dr.Read())
                {
                    d = new detalleFactura();
                    d.idProducto = Convert.ToInt32(dr["idProducto"]);
                    d.descripcion = Convert.ToString(dr["descripcion"]);
                    d.cantidad = Convert.ToInt32(dr["cantidad"]);
                    d.precio = Convert.ToString(dr["precio"]);
                    lista.Add(d);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lista;
        }
    }
}
