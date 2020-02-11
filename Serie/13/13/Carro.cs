using System;
using System.Collections.Generic;
using System.Text;

namespace _13
{
    class Carro
    {
        double peso;
        double altura;
        bool encendido = false;

        public Carro(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public void Encender()
        {
            encendido = true;
            Console.WriteLine("El carro se encendio");
        }

        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("El carro se apagó");
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public void Estado()
        {
            Console.WriteLine("El carro está {0} ",(encendido)? "encendido" : "apagado" );
        }

        public override string ToString()
        {
            return "El carro pesa: "+  peso+ "y mide: " + altura;
        }

    }
}
