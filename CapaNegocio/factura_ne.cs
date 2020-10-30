using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class factura_ne
    {
        public static string[] registrarFactura(string fechaEmision, string fechaVencimiento, int idUsuario, string subTotal, string anticipo, string descuento, string valorVenta, string isc, string igv, string otroCargo, string otroTributo, string importeTotal, int idTipoMoneda, int idTipoUsuario, string totalTexto, string idEmpresa)
        {
            try
            {
                return factura_da.registrarFactura(fechaEmision, fechaVencimiento, idUsuario, subTotal, anticipo, descuento, valorVenta, isc, igv, otroCargo, otroTributo, importeTotal, idTipoMoneda, idTipoUsuario, totalTexto, idEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
