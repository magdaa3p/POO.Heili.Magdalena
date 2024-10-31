using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class Persona
    {
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public int Edad {  get; set; }
        public const int MAYORIA_DE_EDAD = 18;
        
        public Persona(string nombre, string apellido, int edad) {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
        public void Presentarse ()
        {
            Console.WriteLine($"Hola soy {Nombre} {Apellido} tengo {Edad} años");
        }

        public bool EsMayoriaDeEdad()
        {
            return Edad >= MAYORIA_DE_EDAD;
        }
    }
}
