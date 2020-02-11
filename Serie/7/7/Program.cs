using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroComplejo n1 = new NumeroComplejo(1, 8);
            NumeroComplejo n2 = new NumeroComplejo(9, 5);
            NumeroComplejo n3 = n1 + n2;
            Console.WriteLine("Numeros");
            n1.Imprimir();
            n2.Imprimir();

            Console.WriteLine("Imprimir suma");
            n3.Imprimir();
            Console.ReadKey();
        }
    }
}
