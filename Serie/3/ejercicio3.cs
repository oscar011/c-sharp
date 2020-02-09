//Escribir un programa que pida al usuario una cadena de texto e imprima la misma cadena de texto, 
//pero antes de cada vocal, agregue una f
using System;

class Cadena
{	
	static void Main()
	{
		//solicita una cadena
		Console.WriteLine("Escribe una cadena");
		string e = Console.ReadLine();
		//crea una variable que sustituye las vocales con una f mas la vocal.
		var remplazar = e.Replace("a", "fa").Replace("e", "fe").Replace("i", "fi").Replace("o", "fo").Replace("u", "fu");
		//imprime el resultado después de sustituir 
		Console.WriteLine(remplazar);
		Console.ReadKey();
	}
}