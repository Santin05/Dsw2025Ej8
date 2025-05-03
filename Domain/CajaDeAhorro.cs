using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dsw2025Ej8.Domain.Exceptions;

namespace Dsw2025Ej8.Domain
{
    internal class CajaDeAhorro : CuentaBancaria
    {
        public CajaDeAhorro(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares)
        {

        }
        public override void Depositar(decimal monto)
        {
            ValidarOperacion(monto);
            Saldo += monto;
        }
        public override void Retirar(decimal monto)
        {
            ValidarOperacion(monto);
            Saldo -= monto;
        }
    }
}
