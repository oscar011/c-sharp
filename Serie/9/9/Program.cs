using System;

/*
Abs
Devuelve el valor absoluto de un número.

Acos 
Devuelve el ángulo cuyo coseno es el número especificado.

Asin 
Devuelve el ángulo cuyo seno es el número especificado.

Atan 
Devuelve el ángulo cuya tangente es el número especificado.

Atan2
Devuelve el ángulo cuya tangente es el cociente de dos números especificados.

BigMul
Produce el producto completo de dos números de 32 bits.

Techo
Devuelve el valor integral más pequeño que es mayor o igual que el número especificado.

Cos 
Devuelve el coseno del ángulo especificado.

Registro 
Devuelve el logaritmo de un número especificado .

Log10 
Devuelve el logaritmo de base 10 de un número especificado.

Max
Devuelve el mayor de dos números.

Min 
Devuelve el número más pequeño de dos números.

Pow 
Devuelve el valor de un número elevado a una potencia.

Round 
Devuelve el valor inferior o superior dependiendo de sus decimales -> 32.5 = 32 , 32.6 = 33.

Sign 
Devuelve un número que indica el signo.

Sin 
Devuelve el seno de un ángulo.

Sinh 
Devuelve el seno hiperbólico de un ángulo.

Sqrt 
Devuelve la raiz cuadrada de un número.

Tan 
Devuelvela tangente de un ángulo.

Truncate 
Devuelve la parte entera de un número.
*/

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(5.5);
            Console.WriteLine("El area del circulo es: ", c1.AreaCirculo());

            Triangulo t = new Triangulo(5,2);
            Console.WriteLine("La medida de la hipotenusa del triagulo es {0} y su area es {1}", t.Hipotenusa(), t.AreaT());



        }
    }
}
