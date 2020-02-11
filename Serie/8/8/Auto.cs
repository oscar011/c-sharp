using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class Auto
    {
        string modelo;
        string color;
        string velocidad;
        public Auto() { }

        public Auto(string modelo, string color, string velocidad)
        {
            Modelo = modelo;
            Color = color;
            Velocidad = velocidad;
        }

        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Velocidad { get; set; }
        
        public void Acelerar()
        {
            Console.WriteLine("El auto tiene velocidad de {0}", velocidad);
        }
        public void Medir(int peso)
        {
            Console.WriteLine("El auto {0} pesa {1}", modelo, peso);
        }
        public void informacion()
        {
            Console.WriteLine("El auto {0} es de color {1}", modelo, color);
        }
    }
}
