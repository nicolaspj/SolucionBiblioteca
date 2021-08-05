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
            string strSQL = @"Insert Autores(Apellido,Nombre,FechaNacimiento,IdPais)
                              values(@Apellido,@Nombre,@FechaNacimiento,@IdPais)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strSQL, objConexion);
            objCom.CommandType = CommandType.StoredProcedure;
            //params
            objCom.Parameters.AddWithValue("@Apellido", autor.Apellido);
            objCom.Parameters.AddWithValue("@Nombre", autor.Nombre);
            objCom.Parameters.AddWithValue("@FechaNacimiento", autor.FechaNacimiento);
            objCom.Parameters.AddWithValue("@IdPais", autor.IdPais);

            
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
                a.IdPais = Convert.ToInt32(dr["IdPais"]);
                a.Nombre = dr["Nombre"].ToString();
                a.Apellido = dr["Apellido"].ToString();
                a.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                lista.Add(a);
            }
            objCon.Close();
            return lista;
        }


        public static void Modificar (Entidades.Autor autor)
        {
            //store Procedure 
            string strProc = "ProcModiAutor";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strProc, objConexion);
            objCom.CommandType = CommandType.StoredProcedure;
            //parametros
            objCom.Parameters.AddWithValue("@Id", autor.Id);
            objCom.Parameters.AddWithValue("@Nombre", autor.Nombre);
            objCom.Parameters.AddWithValue("@Apellido", autor.Apellido);
            objCom.Parameters.AddWithValue("@FechaNacimiento", autor.FechaNacimiento);
            objCom.Parameters.AddWithValue("@IdPais", autor.IdPais);

            
            objConexion.Open();
            objCom.ExecuteNonQuery();
            objConexion.Close();
        }

        public static void Borrar(int id)
        {
            //store Procedure 
            string strProc = "ProcBorraAutor";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strProc, objConexion);
            objCom.CommandType = CommandType.StoredProcedure;
            //parametros
            objCom.Parameters.AddWithValue("@Id", id);
            
            objConexion.Open();
            objCom.ExecuteNonQuery();
            objConexion.Close();
        }
    }
}
