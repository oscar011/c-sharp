using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de dos objetos tipo cuentaBancaria
            CuentaBancaria c1 = new CuentaBancaria("Oscar", 1000000);
            CuentaBancaria c2 = new CuentaBancaria("Ignacio", 500000);

            c1.mostrarInformacion();
            c1.deposito(100);
            c1.retiro(200);

            c2.mostrarInformacion();
            c2.deposito(200);
            c2.retiro(100);

            Console.ReadKey();
        }
    }
}
