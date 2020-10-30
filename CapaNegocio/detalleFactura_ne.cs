using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class detalleFactura_ne
    {
        public static Boolean registrarDetalleFactura(int idProducto, int cantidad, string precio)
        {
            try
            {
                return detalleFactura_da.registrarDetalleFactura(idProducto, cantidad, precio);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static List<detalleFactura> consultarDetalleRegistrado(string serieFactura, string numFactura)
        {
            try
            {
                return detalleFactura_da.consultarDetalleRegistrado(serieFactura, numFactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
