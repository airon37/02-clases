using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_clases
{
    internal class Libro
    {
        private String titulo;
        private String autor;
        private String estilo;
        private String editorial;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Estilo { get => estilo; set => estilo = value; }
        public string Editorial { get => editorial; set => editorial = value; }

        public Libro(string titulo, string autor, string estilo, string editorial)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Estilo = estilo;
            this.Editorial = editorial;
        }
    }
}
