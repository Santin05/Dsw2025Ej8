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
            ValidarCuenta();
            ValidarMonto(monto);
            Saldo += monto;
        }
        public override void Retirar(decimal monto)
        {
            ValidarCuenta();
            ValidarMonto(monto);
            Saldo -= monto;
        }

        private void ValidarMonto(decimal monto)
        {
            throw new NotImplementedException();
        }

        private void ValidarCuenta()
        {
            throw new NotImplementedException();
        }
    }
}
