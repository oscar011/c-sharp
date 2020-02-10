//Simular una agenda telefonica
using System;
using System.Collections.Generic;

class Agenda
{

    static void Main()
    {
        Dictionary<string, string> agenda = new Dictionary<string, string>();
        string nombre;
        string telefono;
        int str;
        do {
            Console.Write("1) Agregar Contacto \n" + "2) Eliminar Contacto \n" + "3) Mostrar Contacto \n" + "4) Salir \n");
            Console.Write("Seleccione una opción: ");
            str = Convert.ToInt32(Console.ReadLine());
            switch (str)
            {
                case 1:
                    Console.WriteLine("Escribe el nombre del contacto");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Escribe el telefono");
                    telefono = Console.ReadLine();
                    agenda.Add(nombre, telefono);
                    break;
                case 2:
                    Console.WriteLine("Escribe el nombre del contacto");
                    nombre = Console.ReadLine();
                    agenda.Remove(nombre);
                    break;
                case 3:
                    Console.WriteLine("Escribe el nombre del contacto");
                    nombre = Console.ReadLine();
                    Console.WriteLine("{0}:{1}", nombre, agenda[nombre]);
                    break;
                case 4:
                    Console.WriteLine("Adios");
                    break;
            }
        } while(str != 4);
        Console.ReadKey();
    }
}
