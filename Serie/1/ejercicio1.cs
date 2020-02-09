//programa que suma los primeros n numeros naturales 
//n ingresado por el usuario
using System; //importar modulos

class Naturales {


	static void Main(){
		//solicita un numero
		Console.WriteLine("Ingrese un número natural.");
		int n = Convert.ToInt32(Console.ReadLine());
		//utiliza la formula para realizar la suma.
		n=n*(1+n)/2;
		Console.WriteLine("La suma es: {0}",n);
		Console.ReadKey();
	}
}