using System;
using System.Collections.Generic;
using System.Text;

namespace _10
{
    class Persona
    {
        string nombre;
        int edad;
        double estatura;
        double peso;

        public Persona(string nombre, int edad, double estatura, double peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.estatura = estatura;
            this.peso = peso;
        }

        public double IMC()
        {
            return peso / (Math.Pow(estatura, 2));
        }

        public void Calcular(double IMC)
        {
            if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (IMC < 18.5)
            {
                Console.WriteLine("Bajo peso");
            }
            else if (IMC > 24.9)
            {
                Console.WriteLine("Sobrepeso");
            }
        }
        public void Informacion()
        {
            Console.WriteLine("{0} tiene {1} años, pesa {2} kilos y mide {3} mts.", nombre, edad, peso, estatura);
        }
    }
}
