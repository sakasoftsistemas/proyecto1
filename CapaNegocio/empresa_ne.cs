using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class empresa_ne
    {
        public static List<empresa> obtenerEmpresa(int idEmpresa)
        {
            try
            {
                return Empresa_da.obtenerEmpresa(idEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
