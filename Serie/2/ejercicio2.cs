//Realizar un programa en el que se le pida al usuario dos números del 1 al 9, num1 y num2.
//Después va a imprimir todos los números naturales del 1 al 100, 
//sin embargo, cuando un número sea múltiplo de num1 o num2 o contenga alguno de estos números, va a imprimir‘clap’.
using System; 

class Naturales {
	static void Main(){
		//solicita dos numeros entre el 1 y el 9.
		Console.WriteLine("Ingrese dos numeros entre el 1 y el 9.");
		Console.WriteLine("Ingrese primer numero.");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese segundo numero.");
		int num2 = Convert.ToInt32(Console.ReadLine());
		//si alguno de los dos numero es mayor a 9 termina la ejecución
		if(num1>9 || num2>9){
			Console.WriteLine("Ingrese un numero valido.");
		}
		else {
			Console.WriteLine("\n");
			for(int i=1; i<=100; i++){
				//verifica si un numero es multiplo de num1 o num2
				if(i%num1==0 || i%num2==0){
					Console.WriteLine("clap");
				}
				//verifica si i es igual a num1 o num2
				else if(i==num1 || i==num2){
					Console.WriteLine("clap");
				}
				else{
					//imprime los numeros del 1 al 100
					Console.WriteLine("{0}",i);
				}
			}
		}
		



		Console.ReadKey();
	}
}