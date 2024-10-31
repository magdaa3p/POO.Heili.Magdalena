using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class Casa
    {
        public int Capacidad {  get; set; }
        public string ColorExterior { get; set; }
        public List<Persona> Habitantes { get; set; }
        public Direccion Direccion { get; set; }

        public Casa(int capacidad, string colorexterior, Direccion direccion) {
            Capacidad = capacidad;
            ColorExterior = colorexterior;
            Direccion = direccion;
            Habitantes = new List<Persona>();
        }

        public string DescribirCasa()
        {
            return $"Capacidad: {Capacidad}, color exterior: {ColorExterior}";
        }

        public void PresentarHabitantes()
        {
            foreach(var habitante in Habitantes)
            {
                habitante.Presentarse();
            }
        }

        public void PresentarMayoresDeEdad()
        {
            foreach(var habitante in Habitantes)
            {
                if (habitante.EsMayoriaDeEdad())
                {
                    habitante.Presentarse();
                }
            }
        }
    }
}
