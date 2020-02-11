using System;
using System.Collections.Generic;
using System.Text;

namespace _16
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public abstract string Saludar();
    }
    public class Alumno : Persona
    {
        public Alumno(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public override string Saludar()
        {
            string saludo = "Mi nombre es " + this.Nombre + ", soy un alumno y tengo "+ this.Edad + " años";
            return saludo;
        }
    }
    public class Empleado : Persona
    {
        public Empleado(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public override string Saludar()
        {
            string saludo = "Mi nombre es " + this.Nombre + ", soy un empleado y tengo "+ this.Edad +" años";
            return saludo;
        }
    }
}
