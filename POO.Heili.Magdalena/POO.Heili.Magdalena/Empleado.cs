using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class Empleado : Persona
    {
        public string Puesto { get; }
        public decimal Salario { get; private set; }

        public Empleado(string nombre, string apellido, int edad, string puesto, decimal salario)
            : base(nombre, apellido, edad)
        {
            Puesto = puesto;
            Salario = salario;
        }

        public void AumentarSalario(decimal porcentaje)
        {
            Salario += Salario * porcentaje / 100;
        }
    }
}
