using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Logica
{
    public class Pais
    {
        public void Agregar (Entidades.Pais pais)
        {
            Datos.Pais.Agregar(pais);
        }
    }
}
