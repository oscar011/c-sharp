//Pilares de la programación orientada a objetos
using System;

namespace _17
{
    class Poo
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("VMW", 2018);
            Console.WriteLine("Marca: {0}, modelo:{1} ",carro1.Marca, carro1.Año);
            carro1.Velocidad = 100;
            carro1.Acelerar();
            Console.WriteLine(carro1.Velocidad);
            Console.WriteLine(carro1.Informacion());
            carro1.Reversa();
            Console.WriteLine("---------------");
            Camioneta camioneta1 = new Camioneta("GMC", 2017);
            Console.WriteLine("Marca: {0}, modelo:{1} ", camioneta1.Marca, camioneta1.Año);
            camioneta1.Acelerar();
            Console.WriteLine(camioneta1.Informacion());
            camioneta1.Reversa();
            
        }

        //Abstraccion de una entidad automovil
        public abstract class Auto
        {
            //Encapsulamiento
            public string Marca { get; set; }
            public int Año { get; set; }
            public int Velocidad { get; set; }
            public void Acelerar()
            {
                Velocidad += 10;
            }
            public virtual void Reversa()
            {
                Console.WriteLine("Voy de reversa!");
            }
            //Polimorfismo
            public abstract string Informacion();
        }

        //Herencia de la clase auto
        public class Carro : Auto
        {
            public Carro(string marca, int año)
            {
                this.Marca = marca;
                this.Año = año;
            }
            public void EncenderRadio()
            {
                Console.WriteLine("Encendiendo la radio");
            }
            public override string Informacion()
            {
                string saludo = "El auto " + this.Marca + " es del año " + this.Año;
                return saludo;
            }
        }

        public class Camioneta : Auto
        {
            public Camioneta(string marca, int año)
            {
                this.Marca = marca;
                this.Año = año;
            }
            public override void Reversa()
            {
                base.Reversa();
                Console.WriteLine("BEEP BEEP BEEP!");                
            }
            public override string Informacion()
            {
                string saludo = "La camioneta " + this.Marca + " es del año " + this.Año;
                return saludo;
            }
        }
    }
}
