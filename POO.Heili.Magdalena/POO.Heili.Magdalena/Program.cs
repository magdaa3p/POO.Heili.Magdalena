using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear personas
            Persona persona1 = new Persona("magda", "chan", 18);
            Persona persona2 = new Persona("heili", "chon", 28);
            Persona persona3 = new Persona("luis", "momiedo", 15);

            // Presentarse
            persona1.Presentarse();
            persona2.Presentarse();

            // Crear dirección
            Direccion direccion = new Direccion("Calle alguna de parque patricios", 123, "Ciudad", "Barrio");

            // Crear casa
            Casa casa = new Casa(4, "Rojo", direccion);
            casa.Habitantes.Add(persona1);
            casa.Habitantes.Add(persona2);
            casa.Habitantes.Add(persona3);

            // Describir casa y presentar habitantes
            Console.WriteLine(casa.DescribirCasa());
            casa.PresentarHabitantes();

            // Presentar mayores de edad
            Console.WriteLine("Mayores de edad:");
            casa.PresentarMayoresDeEdad();

            // Crear cuenta bancaria
            CuentaBancaria cuenta = new CuentaBancaria(persona1, 1000);
            cuenta.Depositar(500);
            Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo()}");
            cuenta.Retirar(200);
            Console.WriteLine($"Saldo después del retiro: {cuenta.ObtenerSaldo()}");

            // Crear productos
            Producto producto1 = new Producto("Laptop", 1000, 5);
            Producto producto2 = new Producto("Teléfono", 500, 10);

            // Mostrar información de productos
            producto1.MostrarInformacion();
            producto2.MostrarInformacion();

            // Crear carrito de compras
            CarritoDeCompras carrito = new CarritoDeCompras();
            carrito.AgregarProducto(producto1);
            carrito.AgregarProducto(producto2);
            Console.WriteLine($"Total en el carrito: {carrito.CalculoTotal()}");

            // Crear empleado
            Empleado empleado = new Empleado("heili", "xonn", 30, "Desarrollador", 3000);
            empleado.AumentarSalario(10);
            Console.WriteLine($"Nuevo salario de {empleado.Nombre}: {empleado.Salario}");

            // Crear estudiante
            Estudiante estudiante = new Estudiante("thiago", "Magdalena", 22, "Ingeniería", 8.5m);
            estudiante.ActualizarPromedio(9.0m);
            Console.WriteLine($"Nuevo promedio de {estudiante.Nombre}: {estudiante.Promedio}");


            //Crear biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Crear libros
            Libro libro1 = new Libro("Cien años de soledad", "Gabriel García Márquez");
            Libro libro2 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes");

            // Agregar libros a la biblioteca
            biblioteca.AgregarLibros(libro1);
            biblioteca.AgregarLibros(libro2);

            // Crear socios
            Socio socio1 = new Socio("luis", "momiedo", 30);
            Socio socio2 = new Socio("tobias", "moman", 25);

            // Prestar libros
            biblioteca.PrestarLibro(libro1, socio1);
            biblioteca.PrestarLibro(libro2, socio2);

            // Intentar prestar un libro no disponible
            biblioteca.PrestarLibro(libro1, socio2);

            // Devolver libros
            biblioteca.DevolverLibro(libro1, socio1);
            biblioteca.DevolverLibro(libro2, socio2);

            // Intentar devolver un libro que no fue prestado
            biblioteca.DevolverLibro(libro1, socio2);

            // Mostrar libros disponibles en la biblioteca
            Console.WriteLine("\nLibros disponibles en la biblioteca:");
            foreach (var libro in biblioteca.libros)
            {
                Console.WriteLine($"- {libro.Titulo} de {libro.Autor}");
            }
        }
    }
    }

