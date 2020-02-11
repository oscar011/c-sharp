using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Alumno("Oscar", 30);
            Persona p2 = new Empleado("alvaro", 30);
            Console.WriteLine(p1.Saludar());
            Console.WriteLine(p2.Saludar());
            Console.ReadKey();
        }
    }
}
