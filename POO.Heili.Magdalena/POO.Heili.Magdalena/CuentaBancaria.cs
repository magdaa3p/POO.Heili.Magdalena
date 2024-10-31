using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace POO.Heili.Magdalena
{
    public class CuentaBancaria
    {
        public Persona Titular { get; set; }
        private decimal saldo;

        public CuentaBancaria(Persona titular, decimal saldoInicial)
        {
            Titular = titular;
            saldo = saldoInicial;
        }

        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo += monto;
            }
        }

        public bool Retirar(decimal monto) 
        {
            if(monto > 0 && saldo >= monto)
            {
                saldo -= monto;
                return true;
            }
            return false;
        }
        public decimal ObtenerSaldo() 
        {
            return saldo;
        }
    }
}
