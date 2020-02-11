using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroBWM c1 = new CarroBWM(200, 1.70);
            CarroVW c2 = new CarroVW(500, 1.70);

            c1.Encender();
            c1.Estado();
            c1.Apagar();
            c1.Estado();
            Console.WriteLine(c1.ToString());

            c2.Encender();
            c2.Estado();
            c2.Apagar();
            c2.Estado();
            Console.WriteLine(c2.ToString());
        }
    }
}
