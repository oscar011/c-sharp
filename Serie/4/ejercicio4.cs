//Serie fibonacci 
using System;

class Cadena
{
	public static int fibonacci(int n)
	{
		//la implementacion de forma iterativa
		int f1 = 0;
		int f2 = 1;
		for (int i = 1; i < n; i++)
		{
			f2 = f1 + f2;
			f1 = f2 - f1;
		}
		return f2;
	}
	static void Main()
	{
		//solicita un numero
		Console.WriteLine("Escribe un numero");
		int n = Convert.ToInt32(Console.ReadLine());
		//imprime la secuencia de valores desde 0 hasta n
		for (int i = 0; i < n; i++)
		{
			//imprime el numero y su correspondiente en la serie
			Console.WriteLine("{0}={1}", i, fibonacci(i));
		}

		Console.WriteLine();
		Console.ReadKey();
	}
}