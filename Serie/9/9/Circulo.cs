using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{
    class Circulo
    {
        public double Radio { get; set; } 
        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        //area del circulo
        public double AreaCirculo()
        {
            return Math.PI * (Math.Pow(Radio, 2));
        }

        //perimetro del circulo
        public double PerimetroCirculo()
        {
            return Math.PI * Radio * 2;
        }

        //Redondeo del area aal numero mas cercano
        public double AreaEntera()
        {
            return Math.Round(AreaCirculo());
        }
    }
}
