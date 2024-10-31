using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Ciudad { get; set; }
        public string Barrio { get; set; }

        public Direccion(string calle, int altura, string ciudad, string barrio) { 
            Calle = calle;
            Altura = altura;
            Ciudad = ciudad;
            Barrio = barrio;
        }
         public int ObtenerCodigoPostal(){
            return Altura * Calle.Length;
        }

    }

}
