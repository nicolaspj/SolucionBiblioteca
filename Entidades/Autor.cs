
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Autor
    {   //constructor
        public Autor() { }
        public Autor(int pId , string pApellido, string pNombre, DateTime pFechaNacimiento)
        {
            Id = pId;
            Apellido = pApellido;
            Nombre = pNombre;
            FechaNacimiento = pFechaNacimiento;
          

    }
    //atributos
    private int id;
        private string apellido;
        private string nombre;
        //propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre= value; }
        }

        //propiedades autopimoplementadas
        public int IdPais{ get; set; }
        public DateTime FechaNacimiento { get; set; }
        public virtual Pais Pais{ get; set; }
        public List<Libro> Libros{ get; set; }
    }
}
