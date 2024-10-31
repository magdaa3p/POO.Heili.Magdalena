using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class Biblioteca
    {
        public List<Libro> libros = new List<Libro>();
        public List<Socio> socios = new List<Socio>();
        
        public Biblioteca() 
        {
            libros = new List<Libro>();
            socios = new List<Socio>();
        }

        public void AgregarLibros(Libro libro)
        {
            libros.Add(libro);
        }

        public void PrestarLibro(Libro libro, Socio socio) 
        {
            if (libros.Contains(libro))
            {
                libros.Remove(libro);
                socio.AgregarLibroPrestado(libro);
                Console.WriteLine($"{socio.Nombre} a prestado el libro {libro.Titulo}");
            }
            else
            {
                Console.WriteLine($"El libro {libro.Titulo} no esta disponible para prestamo");
            }
        }

        public void DevolverLibro(Libro libro, Socio socio) 
        {
            if (socio.LibrosPrestados.Contains(libro))
            {
                socio.QuitarLibroPrestado(libro);
                libros.Add(libro);
                Console.WriteLine($"{socio.Nombre} a devuelto el libro {libro.Titulo}");   
            }

            else
            {
                Console.WriteLine($"{socio.Nombre} no tiene libro {libro.Titulo} prestado");
            }
        }
    }
}
