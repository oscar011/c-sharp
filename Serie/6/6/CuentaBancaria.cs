using System;
using System.Collections.Generic;
using System.Text;

namespace _6
{
    class CuentaBancaria
    {
        //declaramos variables de los usuarios
        string nombre;
        decimal saldo;

        //constructor que recibe el nombre y el saldo
        public CuentaBancaria(string nombre, decimal saldo)
        {
            this.nombre = nombre;
            this.saldo = saldo;

        }
        //muestra el nombre y el saldo
        public void mostrarInformacion()
        {
            Console.WriteLine("El usuario {0} tiene de saldo: {1}", nombre, saldo);
        }
        //suma lo que hay en saldo con un nuevo deposito
        public void deposito(decimal deposito)
        {
            saldo += deposito;
            mostrarInformacion();
        }
        //resta del saldo un retiro, pero verifica si tiene la cantidad que quiere retirar
        public void retiro(decimal retiro)
        {
            if (saldo<retiro)
            {
                Console.WriteLine("No tienes esa cantidad");
            }
            else
            {
                saldo -= retiro;
                mostrarInformacion();
            }


        }



    }
}
