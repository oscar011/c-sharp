using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
    class NumeroComplejo
    {
        int parteReal;
        int parteImaginaria;

        public NumeroComplejo(int parteReal, int parteImaginaria)
        {
            this.parteReal = parteReal;
            this.parteImaginaria = parteImaginaria;
        }

        //suma de la parte real y la imaginaria respectivamente
        public static NumeroComplejo operator +(NumeroComplejo nc1, NumeroComplejo nc2)
        {
            NumeroComplejo nc= new NumeroComplejo(nc1.parteReal + nc2.parteReal, nc1.parteImaginaria + nc2.parteImaginaria);
            return nc;
        }
        //imprimir las dos partes
        public void Imprimir()
        {
            Console.WriteLine("{0}, {1}i",parteReal , parteImaginaria);
        }
    }
}
