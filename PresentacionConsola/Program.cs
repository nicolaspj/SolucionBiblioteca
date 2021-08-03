using System;
using System.Collections.Generic;

namespace PresentacionConsola
{
   public static class Program
    {
        //creo una lista sde la clase autor
        public static List<Entidades.Autor> listaAutores = new List<Entidades.Autor>(); 
       static void Main(string[] args)
        {
            Logica.Autor objLogica = new Logica.Autor();
            Entidades.Autor objAutor = new Entidades.Autor();
            objAutor.Id = 3;
            objAutor.Nacionalidad = "aRG";
            objAutor.Nombre = "pep";
            objAutor.Apellido = "argento";
            objAutor.FechaNacimiento = Convert.ToDateTime("01/01/2020");
            objLogica.Agregar(objAutor, Program.listaAutores);
            Entidades.Autor autor = new Entidades.Autor(1, "perz", "juan", Convert.ToDateTime("01/01/2000"), "arg");
            objLogica.Agregar(autor, Program.listaAutores);

            Entidades.Autor autor2 = new Entidades.Autor { Id = 2, Apellido = "Garcia", Nombre = "Charlie", FechaNacimiento = Convert.ToDateTime("01/01/2000"), Nacionalidad = "arg" };
            objLogica.Agregar(autor2, Program.listaAutores);
            //listaAutores.Add(objAutor);
            //listaAutores.Add(autor);
            //listaAutores.Add(autor2);

            //mostrar la lista de autores
            Console.WriteLine("Autores");
            foreach (var a in listaAutores)
            {
                Console.WriteLine($"{a.Id} {a.Apellido} {a.Nombre} {a.FechaNacimiento} {a.Nacionalidad}");
            }
            Console.WriteLine($"\nCantidad de autores : {objLogica.TraerCantidad(listaAutores)}");
            Console.ReadKey();
        
        }
    }  
}
