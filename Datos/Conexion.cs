using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    static internal class Conexion
    {
        static internal string strConexion = ConfigurationManager.ConnectionStrings["Cadena"].ToString();
         
    }
}
