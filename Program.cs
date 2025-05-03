using Dsw2025Ej8.Domain;
using static Dsw2025Ej8.Domain.Exceptions;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria[] cuentas = new CuentaBancaria[4];

            try
            {
                var cuenta = new CajaDeAhorro("A101", 1500, new string[] { "Lopez", "Martina" })
                {
                    TasaDeInteres = 0.05m,
                };
                cuenta.Depositar(800m);
                cuenta.Retirar(1000m);
                cuentas[0] = cuenta;
            }
            catch (Exception e)
            {
                controladorexcepciones.Handle(e);
            }

            try
            {
                var cuenta = new CajaDeAhorro("A102", 3000, new string[] { "Juarez", "Bruno" })
                {
                    TasaDeInteres = 0.04m,
                };
                cuenta.Depositar(200m);
                cuenta.Retirar(1200m);
                cuentas[1] = cuenta;
            }
            catch (Exception e)
            {
                controladorexcepciones.Handle(e);
            }

            try
            {
                var cuenta = new CuentaCorriente("C201", 1800, new string[] { "Silva", "Paula" })
                {
                    Comision = 0.15m,
                    LimiteDeDescubierto = 1200m,
                };
                cuenta.Depositar(600m);
                cuenta.Retirar(2500m);
                cuentas[2] = cuenta;
            }
            catch (Exception e)
            {
                controladorexcepciones.Handle(e);
            }

            try
            {
                var cuenta = new CuentaCorriente("C202", 700, new string[] { "Rojas", "Tomas" })
                {
                    Comision = 0.1m,
                    LimiteDeDescubierto = 500m,
                };
                cuenta.Depositar(400m);
                cuenta.Retirar(1300m);
                cuentas[3] = cuenta;
            }
            catch (Exception e)
            {
                controladorexcepciones.Handle(e);
            }

            Console.WriteLine("\t  ***RESUMEN DE CUENTAS:***  ");

            foreach (var c in cuentas)
            {
                if (c != null)
                {
                    var datos = new
                    {
                        Numero = c.Numero,
                        Tipo = c.GetType().Name,
                        Saldo = c.Saldo
                    };

                    Console.WriteLine($"Nro: {datos.Numero}, Tipo: {datos.Tipo}, Saldo: {datos.Saldo:C}");
                }
            }
        }
    }
}
