//BecarioMart Compras semanales
using System;
using System.Collections.Generic;

class BecarioMart
{
    static void Main()
    {
        //variables que vamos a utilizar
        string producto;
        double dinero;
        string respuesta;
        double total = 0;
        int indice;
        int str;
        //listas de nombre del producto y su precio
        List<string> nombre = new List<string>();
        List<double> precio = new List<double>();
        //al iniciar el programa le pide al usuario el nombre del producto y el precio
        do
        {
            Console.WriteLine("Nombre del producto");
            producto = Console.ReadLine();
            nombre.Add(producto);
            Console.WriteLine("Precio del producto");
            //si escribe algo que no sea un numero lo captura con esta excepcion
            try
            {
                dinero = Convert.ToDouble(Console.ReadLine());
                precio.Add(dinero);
            }
            catch (FormatException formate)
            {
                Console.WriteLine("Debe ingresar un numero");
                Console.ReadKey();
            }
            //despues de escribir un producto le pregunta al usuario si quiere agregar otro
            Console.WriteLine("¿Quiere agregar más productos? (Y/N)");
            respuesta = Console.ReadLine();
            //si la respues del usuario es "Y/y" repite el ciclo, de lo contrario pasa a la sigiente parte del codigo
        } while (respuesta=="Y"||respuesta=="y");
        //iteracion para sacar los valores de la lista
        for (int i = 0; i < nombre.Count; i++)
        {
            Console.WriteLine("Nombre producto: {0} Precio: {1} Numero {2}", nombre[i], precio[i], i+1);
            //suma de los precios para el total
            total += precio[i];
            
        }
        Console.WriteLine("Total: {0}", total);

        //menu para desicion del usuario, comprar o dejar
        do
        {
            Console.WriteLine("Accion: \n 1) Comprar. \n 2) Dejar productos. \n 3) Salir.");
            Console.Write("Seleccione una opción: ");
            str = Convert.ToInt32(Console.ReadLine());
            switch (str)
            {
                case 1:
                    //verifica que el total sea menor de 500
                    if (total>500)
                    {
                        Console.WriteLine("Dinero insuficiente");
                        Console.WriteLine("Necesita dejar algún producto");
                    }
                    else
                    {
                        Console.WriteLine("Gracias por su compra!");
                        Console.ReadKey();
                        break;
                    }
                    break;
                    //dejar un producto con el numero de su indice
                case 2:
                    total = 0;
                    Console.WriteLine("Indique el numero del producto que desea dejar");
                    for (int i = 0; i < nombre.Count; i++)
                    {
                        Console.WriteLine("Nombre producto: {0} Precio: {1} Numero {2}", nombre[i], precio[i], i + 1);
                    }
                    indice = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        nombre.RemoveAt(indice);
                        precio.RemoveAt(indice);
                        for (int i = 0; i < nombre.Count; i++)
                        {
                            Console.WriteLine("Nombre producto: {0} Precio: {1} Numero {2}", nombre[i], precio[i], i + 1);
                            total += precio[i];
                        }
                        Console.WriteLine(total);
                        break;
                    }
                    catch (IndexOutOfRangeException ioore)
                    {
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                    }
                case 3:
                    Console.WriteLine("Adios");
                    break;
            }
        } while (str != 4);

        Console.ReadKey();
    }
}
