using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Datos
{
    public class Pais
    {
        public static void  Agregar (Entidades.Pais pais)
        {
            string strSQL = " Insert Pais(Nombre) values(@Nombre)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strSQL, objConexion);
            //params
            objCom.Parameters.AddWithValue("@Nombre", pais.Nombre);
            objConexion.Open();
            objCom.ExecuteNonQuery();
            objConexion.Close();

        }
    }
}
