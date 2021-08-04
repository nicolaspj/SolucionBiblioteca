using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos
{
    public static class Autor
    {
        //metodos de acceso  a datos
        public static void Agregar(Entidades.Autor autor)
        {
            string strSQL = @"Insert Autores(Apellido,Nombre,FechaNacimiento,Nacionalidad)
                              values(@Apellido,@Nombre,@FechaNacimiento,@Nacionalidad)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strSQL, objConexion);
            //params
            objCom.Parameters.AddWithValue("@Apellido", autor.Apellido);
            objCom.Parameters.AddWithValue("@Nombre", autor.Nombre);
            objCom.Parameters.AddWithValue("@FechaNacimiento", autor.FechaNacimiento);
            objCom.Parameters.AddWithValue("@Nacionalidad", autor.Nacionalidad);


            objConexion.Open();
            
            objCom.ExecuteNonQuery();
            objConexion.Close();


        }


        public static List<Entidades.Autor> Traer()
        {
            List<Entidades.Autor> lista = new List<Entidades.Autor>();
            SqlDataReader dr;
            SqlConnection objCon = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand("Select * from autores ", objCon);
            objCon.Open();
            dr = objCom.ExecuteReader();
            while (dr.Read())
            {
                Entidades.Autor a = new Entidades.Autor();
                a.Id = Convert.ToInt32(dr["Id"]);
                a.Nacionalidad = dr["Nacionalidad"].ToString();
                a.Nombre = dr["Nombre"].ToString();
                a.Apellido = dr["Apellido"].ToString();
                a.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                lista.Add(a);
            }
            objCon.Close();
            return lista;
        }
    }
}
