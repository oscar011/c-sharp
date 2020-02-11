using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            double estatura;
            double peso;

            Console.WriteLine("Escribe el nombre de la persona");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe su estatuta en metros");
            estatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe su peso en kilogramos");
            peso = Convert.ToDouble(Console.ReadLine());
            
            Persona p = new Persona(nombre, edad, estatura, peso);
            p.Informacion();
            p.IMC();
            Console.WriteLine("El IMC de la persona es: {0}", p.IMC());
            p.Calcular(p.IMC());
            Console.ReadKey();
        }
    }
}
