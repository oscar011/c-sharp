using System;
using System.Collections.Generic;
using System.Text;

namespace _13
{
    class CarroBWM : Carro
    {

        string modelo="BWM";

        public CarroBWM(double peso, double altura) : base(peso, altura)
        {
        }
        public override string ToString()
        {
            return "Tengo turbo \n El peso es: " + Peso + "\n La altura es: " + Altura + "\n El modelo es: " + modelo;
        }

    }
}
