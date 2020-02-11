//Calculadora
using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables que vamos a ocupar
            int n1 = 0;
            int n2 = 0; 
            int str;
            int resultado;
            do
            {
                try
                {
                    //solicita los dos numeros al usuario
                    Console.WriteLine("Escribe el primer numero");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe el segundo numero");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    //verifica si es muy grandde alguno de los dos numeros
                    if (n1 > 9999999 || n2 > 9999999)
                    {
                        Console.WriteLine("El numero es demasiado grande");
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Se debe escribir numeros");
                    Console.ReadKey();
                }
                //menu
                Console.WriteLine("1) Suma \n 2) Resta \n 3) Multiplicacion \n 4) Division \n 5) Salir");
                Console.WriteLine("Selecciona una opción");
                str = Convert.ToInt32(Console.ReadLine());
                switch (str)
                {
                    case 1:
                        resultado = n1 + n2;
                        Console.WriteLine(resultado);
                        break;
                    case 2:
                        resultado = n1 - n2;
                        Console.WriteLine(resultado);
                        break;
                    case 3:
                        resultado = n1 * n2;
                        Console.WriteLine(resultado);
                        break;
                    case 4:
                        //la division entre cero no es posible
                        if (n2==0)
                        {
                            Console.WriteLine("No se pueden hacer divisiones entre cero");
                        }
                        else
                        {
                            resultado = n1 / n2;
                            Console.WriteLine(resultado);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Adios");
                        break;
                }

            } while (str != 5);
            Console.ReadKey();

        }
    }
}
