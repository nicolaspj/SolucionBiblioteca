using System;
using System.Collections.Generic;

namespace ConsolaTest
{
    public class Program
    {
        static List<Entidades.Autor> listaAutores = new List<Entidades.Autor>();


        static void Main(string[] args)
        {
            int intOpcion;
            do
            {
                Console.Clear();
                Console.WriteLine("****************");
                Console.WriteLine("Consola Presentacion");
                Console.WriteLine("\n1.Agregar \n2.Mostrar Lista \n3.Filtrar x Pais \n4.Borrar \n5. Fin ");
                Console.WriteLine("****************");
                
                intOpcion = Convert.ToInt32(Console.ReadLine());
                switch (intOpcion)
                {
                    case 1://agregar autor
                        Nuevo();
                        break;

                    case 2:
                        Mostrar();
                        break;
                    case 3:
                        MostrarxPais();
                        break;
                    case 4:
                        Borrar();
                        break;
                    case 5:

                        break;
                }


            } while (intOpcion != 5);

        }
        static void Nuevo()
        {
            Entidades.Autor objEntidad = new Entidades.Autor();
            Console.Write("id:");
            objEntidad.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("apellido:");
            objEntidad.Apellido = Console.ReadLine();

            Console.Write("nombre:");
            objEntidad.Nombre = Console.ReadLine();
            Console.Write("fecha nac:");
            
            
            
            objEntidad.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("nacionalidad:");
            objEntidad.Nacionalidad = Console.ReadLine();

            /* Logica.Autor objLogica = new Logica.Autor();
             objLogica.Agregar(objEntidad, listaAutores);
            --para agregar sin la bd
             */
            //para agregar con la BD
            Logica.Autor objLogica = new Logica.Autor();
            objLogica.Agregar(objEntidad);

            Console.WriteLine("Autor agregado a la BD ,pulse para continuar");
            Console.ReadKey();
        }

        static void Mostrar()
        {
            Logica.Autor objLogica = new Logica.Autor();
            //mostramos autores
            List<Entidades.Autor> listaAutores = objLogica.Traer();
            Console.WriteLine("Autores");
            foreach (var a in objLogica.Traer())
            {
                Console.WriteLine($"{a.Id} {a.Apellido} {a.Nombre} {a.FechaNacimiento} {a.Nacionalidad}");
            }
            Console.WriteLine($"\nCantidad de autores : {listaAutores.Count} / pulse para continuar");
            Console.ReadKey();
        }
        static void MostrarxPais()
        {
            Logica.Autor objLogica = new Logica.Autor();
            Console.Write("Pais a consultar:");
            string strPais = Console.ReadLine();
            List<Entidades.Autor> listaPais = objLogica.FiltrarxPais(strPais, listaAutores);
            //mostrar la lista de autores
            Console.WriteLine($"Autores de {strPais}");
            foreach (var a in listaPais)
            {
                Console.WriteLine($"{a.Id} {a.Apellido} {a.Nombre} {a.FechaNacimiento} {a.Nacionalidad}");
            }
           
            Console.WriteLine($"\nCantidad de autores : {strPais} = {objLogica.TraerCantidad(listaPais)} \nPrecione tecla para cont");
            Console.ReadKey();
        }

        static void Borrar()
        {
            Entidades.Autor objEntidad = new Entidades.Autor();
            Console.Write("Ingrese Id a borrar:");
            int intId = Convert.ToInt32(Console.ReadLine());
            Logica.Autor objLogica = new Logica.Autor();
            objLogica.Borrar(intId, listaAutores);
            Console.WriteLine($"\n el Autor {intId} ha sido borrado, pulse para cont");
            Console.ReadKey();
        }

    }

}
