using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            Auto auto2 = new Auto("Fiesta", "rojo", "100km");
            Auto auto3 = new Auto("A3", "azul", "100km");

            auto1.Modelo="A1";
            auto1.Color = "negro";
            auto1.Velocidad = "100km";
            auto1.informacion();

            auto2.Velocidad = "300.00";
            auto2.Acelerar();

            auto3.Medir(500);
        }
    }
}
