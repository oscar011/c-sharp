using System;
using System.Collections.Generic;
using System.Text;

namespace _13
{
    class CarroVW : Carro 
    {
        string modelo="VW";

        public CarroVW(double peso, double altura) : base(peso, altura)
        {
        }

        public override string ToString()
        {
            return "El peso es: " + Peso + "\n La altura es: " + Altura + "\n El modelo es: " + modelo;
        }

    }
}
