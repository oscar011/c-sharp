using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Consola
{
    class Program
    {
        public static string cambiarDirectorio(string argumento)
        {
            //Manejo de excepciones en directorio no encotrado y acceso no autorizado
            try
            {
                //Cambia el directorio actual
                Environment.CurrentDirectory = (argumento);
                return Directory.GetCurrentDirectory();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ruta no valida");
                return Directory.GetCurrentDirectory();
            }
        }
        static void Main(string[] args)
        {
            //variable a My Documents
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //variable para nuevos path
            string path = Directory.GetCurrentDirectory();
            //lista para almacenar los comandos escritos
            List<string> historial = new List<string>();
            while (true)
            {
                //leer desde consola
                string comando;
                Console.WriteLine(docPath + ":");
                comando = Console.ReadLine();
                //agregar los comandos escritos a la lista historial
                historial.Add(comando);
                //almacenar argumentos de comando
                string[] argumentos= comando.Split(" ");
                string argumento = argumentos[0];
                if (argumentos.Length != 1)
                {
                    argumento = argumentos[1];
                }
                if (comando == "dir")
                {
                    try
                    {
                        List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
                        DirectoryInfo di = new DirectoryInfo(docPath);
                        foreach (var dir in di.GetFiles())
                        {
                            Console.WriteLine(dir.Name);
                        }
                        foreach (var dir in dirs)
                        {
                            Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
                        }

                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (PathTooLongException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (comando == "cd")
                {
                    path = cambiarDirectorio(argumento);
                }
                if (comando == "touch")
                {
                    try
                    { 
                        // Create a new file     
                        using (FileStream fs = File.Create(argumentos[1]))
                        {
                            // Add some text to file    
                            Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                            fs.Write(title, 0, title.Length);
                            byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                            fs.Write(author, 0, author.Length);
                        }
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex.ToString());
                    }

                }
                if (comando == "move")
                {
                   
                    try
                    {
                        Directory.Move(argumentos[1], argumentos[2]);
                    }
                    catch (IOException exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                }
                if (comando == "history")
                {
                    foreach (string history in historial)
                    {
                        Console.WriteLine(history);
                    }
                }
                if (comando == "cls")
                    Console.Clear();
                if (comando == "exit")
                    break;
            }


        }


    }
}
