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
    public class Empresa_da
    {
        static SqlConnection con = conexion.getConexion();
        public static List<empresa> obtenerEmpresa(int iidEmpresa)
        {
            List<empresa> lista = new List<empresa>();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_datosEmpresa", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idEmpresa", iidEmpresa);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                empresa p;
                while (dr.Read())
                {
                    p = new empresa();
                    int idEmpresa = Convert.ToInt32(dr["idEmpresa"]);
                    string nombreEmpresa = dr["nombreEmpresa"].ToString();
                    string nombreComercial =dr["nombreComercial"].ToString();
                    string ruc = dr["ruc"].ToString();
                    string direccion = dr["direccion"].ToString();
                    string departamento = dr["departamento"].ToString();
                    string provincia = dr["provincia"].ToString();
                    string distrito = dr["distrito"].ToString();
                    p.idEmpresa = idEmpresa;
                    p.nombreEmpresa = nombreEmpresa;
                    p.nombreComercial = nombreComercial;
                    p.direccion = direccion;
                    p.ruc = ruc;
                    p.departamento = departamento;
                    p.provincia = provincia;
                    p.distrito = distrito;
                    lista.Add(p);
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
