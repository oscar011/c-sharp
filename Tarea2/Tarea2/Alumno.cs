using System;
using System.Collections.Generic;
using System.Text;

namespace Calificaciones
{
    class Alumno
    {
        public string nombre, apPaterno, apMaterno; public int proyecto, tareas, participacion, promedio;

        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public int Proyecto { get; set; }
        public int Tareas { get; set; }
        public int Participacion { get; set; }
        public int Promedio { get; set; }


        public Alumno()
        {
        }

    }
}
