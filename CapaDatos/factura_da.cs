using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class factura_da
    {
        static SqlConnection con = conexion.getConexion();
        public static string[] registrarFactura(string fechaEmision, string fechaVencimiento, int idUsuario, string subTotal, string anticipo, string descuento, string valorVenta, string isc, string igv, string otroCargo, string otroTributo, string importeTotal, int idTipoMoneda, int idTipoUsuario, string totalTexto,string idEmpresa)
        {
            string[] data = new string[2];
            try
            {
                SqlCommand cmd = new SqlCommand("usp_insertarFactura", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                cmd.Parameters.AddWithValue("@fechaEmision", fechaEmision);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@subTotal", Convert.ToDouble(subTotal));
                cmd.Parameters.AddWithValue("@anticipo", Convert.ToDouble(anticipo));
                cmd.Parameters.AddWithValue("@descuento", Convert.ToDouble(descuento));
                cmd.Parameters.AddWithValue("@valorVenta", Convert.ToDouble(valorVenta));
                cmd.Parameters.AddWithValue("@isc", Convert.ToDouble(isc));
                cmd.Parameters.AddWithValue("@igv", Convert.ToDouble(igv));
                cmd.Parameters.AddWithValue("@otroCargo", Convert.ToDouble(otroCargo));
                cmd.Parameters.AddWithValue("@otroTributo", Convert.ToDouble(otroTributo));
                cmd.Parameters.AddWithValue("@importeTotal", Convert.ToDouble(importeTotal));
                cmd.Parameters.AddWithValue("@idTipoMoneda", idTipoMoneda);
                cmd.Parameters.AddWithValue("@idTipoUsuario", idTipoUsuario);
                cmd.Parameters.AddWithValue("@totalTexto", totalTexto);
                cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    data[0] = dr["serieFactura"].ToString();
                    data[1] = dr["numFactura"].ToString();
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
            return data;
        }
    }
}
