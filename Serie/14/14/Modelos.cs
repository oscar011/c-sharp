using System;
using System.Collections.Generic;
using System.Text;

namespace _14
{
    class Modelos
    {
    }
    class Bochito : IMotor
    {
        public int Peso { get; }
        public int Potencia { get; }

        public Bochito()
        {
            Peso = 800;
            Potencia = 2000;
        }

        public void Iniciar()
        {
            Console.WriteLine("El motor enciende lento");
        }

        public void Detener()
        {
            Console.WriteLine("El motor se apaga");
        }
    }

    class Carreras : IMotor
    {
        public int Peso { get; }
        public int Potencia { get; }

        public Carreras()
        {
            Peso = 500;
            Potencia = 20000;
        }

        public void Iniciar()
        {
            Console.WriteLine("El motor tiene mucha potencia");
        }

        public void Detener()
        {
            Console.WriteLine("El motor acelera muy rapido");
        }
    }

    class Audi : IMotor
    {
        public int Peso { get; }
        public int Potencia { get; }

        public Audi()
        {
            Peso = 700;
            Potencia = 1000;
        }

        public void Iniciar()
        {
            Console.WriteLine("El motor enciende rapido");
        }

        public void Detener()
        {
            Console.WriteLine("El motor se apaga rapido");
        }
    }
}
