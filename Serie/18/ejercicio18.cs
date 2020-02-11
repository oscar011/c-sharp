//Maneo de Archivos
using System;
using System.IO;

/*
Se necesita utilizar la libreria using System.IO para hacer el manejo de archivos
-FileStream, cuyo propósito es lectura y escritura de datos binarios (no de texto legible), 
a cualquier archivo de tipo binario, aunque se puede utilizar para acceder a cualquier tipo de archivo, 
inclusive los de texto.
-StreamReader y StreamWriter, las cuales están diseñadas para lectura y escritura de archivos de texto. 
Estas clases se asumen como de un nivel más alto que FileStream.
*/

namespace archivoss
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero; //Clase que representa un fichero
            fichero = File.CreateText("prueba.txt"); //Creacion un fichero
            fichero.WriteLine("Escritura en archivo"); //escribir dentro del archivo
            fichero.Close(); //Se tiene que cerrar el archivo
            
            //Lectura del archivo
            StreamReader fichero1;
            string linea;
            fichero1 = File.OpenText("prueba.txt");
            linea = fichero1.ReadLine();
            Console.WriteLine(linea);
            //lectura hasta el final del archivo
            do
            {
                linea = fichero1.ReadLine();
            } while (linea != null);
            fichero1.Close();

            Console.ReadKey();
        }
    }
}