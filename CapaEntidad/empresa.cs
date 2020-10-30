using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class empresa
    {
        public int idEmpresa { get; set; }
        public string nombreEmpresa { get; set; }
        public string nombreComercial { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        int  estado { get; set; }
    }
}
