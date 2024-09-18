using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Libro
    {
        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        private int numpaginas;
        public int NumPaginas
        {
            get { return numpaginas; }
            set { numpaginas = value; }
        }

        public override string ToString()
        {
            return $"El libro con ISBN {ISBN} creado por el autor {Autor} tiene {NumPaginas} paginas.";
        }
    }
}
