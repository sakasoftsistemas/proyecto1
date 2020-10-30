using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class login_ne
    {
        public static List<usuario> iniciarSesion(string usu, string clave)
        {
            try
            {
                return login_da.iniciarSesion(usu, clave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
