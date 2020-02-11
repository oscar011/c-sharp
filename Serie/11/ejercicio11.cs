using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables que vamos a utilizar
            int n=0;
            int str;
            //public double[,] matriz1;
            //public double[,] matriz2;
            //double[,] matriz3;

            
            do
            {
                //solicita un numero para crear la matriz
                Console.WriteLine("Ingresa un numero, será la dimension de la matriz (matriz cuadrada)");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar un numero");
                }

                //crea las dos matrices del tamaño ingresado
                double[,] matriz1 = new double[n, n];
                double[,] matriz2 = new double[n, n];

                //menu
                Console.WriteLine("1) Suma \n 2) Resta \n 3) Multiplicacion \n 4) Salir");
                Console.WriteLine("Selecciona una opción");
                str = Convert.ToInt32(Console.ReadLine());
                switch (str)
                {
                    case 1:
                        Cargar(n, matriz1, matriz2);
                        Suma(matriz1, matriz2, n);
                        Console.WriteLine();
                        break;
                    case 2:
                        Cargar(n, matriz1, matriz2);
                        Resta(matriz1, matriz2, n);
                        Console.WriteLine();
                        break;
                    case 3:
                        Cargar(n, matriz1, matriz2);
                        Multiplicacion(matriz1, matriz2, n);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Adios");
                        break;
                }

            } while (str != 4);
            
            
            Console.ReadKey();
        }
        public static void Cargar(int n, double[,] matriz1, double[,] matriz2)
        {
            Console.WriteLine("Ingresando datos al matriz 1");
            for (int i = 1; i <= matriz1.Length; i++)
            {
                for (int j = 1; j <= matriz1.Length; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    matriz1[i, j] = double.Parse(linea);
                }
            }
            Console.WriteLine("Ingresando datos al matriz 2");
            for (int i = 1; i <= matriz2.Length; i++)
            {
                for (int j = 1; j <= matriz2.Length; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    matriz2[i, j] = double.Parse(linea);
                }
            }
        }
        public static void Suma(double [,] matriz1, double [,] matriz2, int n )
        {
            double[,] matriz3 = new double[n, n];
            //Sumamos la matriz1 y la Matriz2
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            //visualizamos la suma de las matrices
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(matriz3[i, j] + "  ");
                }
            }
            Console.ReadKey();
        }
        public static void Resta(double[,] matriz1, double[,] matriz2, int n)
        {
            double[,] matriz3 = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz3[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }
            //visualizamos la matriz resultante
            Console.WriteLine("Resta de 2 Matrices");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0} ", matriz3[i, j]);
                    //Muestra el resultado total 
                }
            }
        }
        public static void Multiplicacion(double[,] matriz1, double[,] matriz2, int n)
        {
            double[,] matriz3 = new double[n, n];
            //Multiplicando las 2 matrices 
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    matriz3[i, j] = 0;
                    for (int z = 1; z <= n; z++)
                    {
                        matriz3[i, j] = matriz1[i, z] * matriz2[z, j] + matriz3[i, j];
                    }
                }
            }
            Console.WriteLine("Multiplicacion de 2 Matrices");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0} ", matriz3[i, j]);
                    //Muestra el resultado total 
                }
            }
        }



    }
}