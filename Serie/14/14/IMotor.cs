using System;
using System.Collections.Generic;
using System.Text;

namespace _14
{
    interface IMotor
    {
        void Iniciar();
        void Detener();
        int Peso { get; }
        int Potencia { get; }
    }
}
