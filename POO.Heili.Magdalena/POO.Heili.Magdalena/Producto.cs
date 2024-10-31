using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; private set; }
        public int CantidadDisponible { get; private set; }

        public Producto(string nombre, decimal precio, int cantidaddisponible) 
        {
            Nombre = nombre;
            Precio = precio;
            CantidadDisponible = cantidaddisponible;
        }

        public void AjustarPrecio (decimal nuevoPrecio)
        {
            Precio = nuevoPrecio;
        }

        public void AjustarCantidadDisponible(int nuevaCantidad)
        {
            CantidadDisponible = nuevaCantidad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, precio: {Precio}, cantidad disponible: {CantidadDisponible}");
        }
    }
}
