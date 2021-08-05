using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public int ISBN { get; set; }
        public string Titulo{ get; set; }
        public string Edicion{ get; set; }
        public Genero Genero{ get; set; }
        public int IdGenero{ get; set; }
        public Editorial Editorial{ get; set; }
        public int IdEditorial{ get; set; }

        public List<Autor> Autores { get; set; }
    }
}
