using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{
    class Triangulo
    {
        public Triangulo(int medidaBase, int altura)
        {
            MedidaBase = medidaBase;
            Altura = altura;
        }
        public int MedidaBase { get; set; }
        public int Altura { get; set; }

        public int Hipotenusa()
        {
            return (int)Math.Sqrt(Math.Pow(MedidaBase, 2) + Math.Pow(Altura, 2));
           
        }
        public long AreaT()
        {
            return (MedidaBase*Altura)/2;
        }
    }
}
