using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        //metodos
        public void Agregar(Entidades.Autor autor,List<Entidades.Autor> autores)
        {
            autores.Add(autor);
        }
      
        public int TraerCantidad(List<Entidades.Autor> autores)
        {
            int intCantidad = autores.Count;
            return intCantidad;
        }

        public List<Entidades.Autor> FiltrarxPais (string pais, List<Entidades.Autor> autores)
        {
            var lista = from a in autores
                        where a.Nacionalidad == pais
                        select a;
                return lista.ToList();
        }


        public void Modificar (Entidades.Autor autor)
        {

        }

        public void Borrar (int id, List<Entidades.Autor> lista)
        {
            foreach (var item in lista)
            {
                if(id ==item.Id)
                {
                    lista.Remove(item);
                    break;
                }

            }

        }
        //metodos de acceso a la BD
        public void Agregar(Entidades.Autor autor)
        {
            Datos.Autor.Agregar(autor);
        }

        public List<Entidades.Autor> Traer()
        {
            return Datos.Autor.Traer();
        }
    }
}
