using System;

namespace Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int pr;
            Console.WriteLine("Ingresa el número de alumnos a calificar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumn = new Alumno[numero];

            for (int i = 0; i < alumn.Length; i++)
            {
                Alumno alumnos = new Alumno();
                Console.WriteLine("Datos del alumno {0}", i + 1);
                Console.Write("Nombre: ");
                alumnos.Nombre = Console.ReadLine();
                Console.Write("Apellido Paterno: ");
                alumnos.ApPaterno = Console.ReadLine();
                Console.Write("Apellido Materno: ");
                alumnos.ApMaterno = Console.ReadLine();
                Console.Write("Calificacion del proyecto: ");
                alumnos.Proyecto = Convert.ToInt32(Console.ReadLine());
                Console.Write("Calificacion de tareas: ");
                alumnos.Tareas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Calificacion de participaciones: ");
                alumnos.Participacion = Convert.ToInt32(Console.ReadLine());

                alumnos.Promedio = Calculadora.promedio(alumnos.Tareas, alumnos.Proyecto, alumnos.Participacion);

                if (alumnos.Promedio > 100)
                {
                    alumnos.Promedio = 100;
                }
                else
                if (alumnos.Promedio < 50)
                {
                    alumnos.Promedio = 50;
                }
                alumn[i] = alumnos;


            }

            foreach (Alumno al in alumn)
            {
                Console.WriteLine(al);
                Console.WriteLine("La calificacion final de " + al.Nombre + " " + al.ApPaterno + " " + al.ApMaterno + " es de " + al.Promedio + "/100");
            }
            Console.ReadKey();
        }
    }
}
