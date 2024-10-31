using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class CarritoDeCompras
    {
        public List<Producto> productos {  get; set; }

        public CarritoDeCompras() 
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto (Producto producto)
        {
            productos.Add(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            productos.Remove(producto);
        }

        public void VaciarCarrito()
        {
            productos.Clear();
        }

        public decimal CalculoTotal()
        {
            decimal total = 0;
            foreach (var producto in productos) 
            {
                total += producto.Precio;
            }
            return total;
        }

    }
}
