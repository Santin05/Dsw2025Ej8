using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dsw2025Ej8.Domain.Exceptions;

namespace Dsw2025Ej8.Domain
{
    public class CuentaCorriente : CuentaBancaria
    {

        public CuentaCorriente(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares)
        {

        }
        public decimal LimiteDeDescubierto { get; init; }
        public decimal Comision { get; init; }

        public override void Depositar(decimal monto)
        {
            ValidarCuenta();
            ValidarMonto(monto);
            decimal montoFinal = monto - (monto * Comision);
            Saldo += montoFinal;
        }

        private void ValidarCuenta()
        {
            throw new NotImplementedException();
        }

        private void ValidarMonto(decimal monto)
        {
            throw new NotImplementedException();
        }

        public override void Retirar(decimal monto)
        {
            ValidarCuenta();
            ValidarMonto(monto);

            if (Saldo - monto >= -LimiteDeDescubierto)
            {
                Saldo -= monto;

                if (Saldo < 0)
                {
                    Estado = Estado.Suspendida;
                    throw new SaldoInsuficiente($"Cuenta {Numero}: La cuenta no cuenta con saldo suficiente para la operacion. Fue suspendida");
                }
            }

        }
    }


}