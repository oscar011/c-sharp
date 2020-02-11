using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Bochito b1 = new Bochito();
            Audi a1 = new Audi();
            Carreras c1 = new Carreras();

            Console.WriteLine("Bocho");
            Console.WriteLine("Peso {0} potencia{1} ", b1.Peso, b1.Potencia);
            Console.WriteLine("Audi");
            Console.WriteLine("Peso {0} potencia{1} ", a1.Peso, a1.Potencia);
            Console.WriteLine("Auto de carreras");
            Console.WriteLine("Peso {0} potencia{1} ", c1.Peso, c1.Potencia);
        }

    }
}
