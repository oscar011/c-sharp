using System;
using System.Collections.Generic;
using System.Text;

namespace Calificaciones
{
    public static class Calculadora
    {
        public static int promedio(int proyecto, int tareas, int participacion)
        {
            if (participacion > 5)
            {
                return (proyecto * 60 + tareas * 40) + 80;
            }
            return (proyecto * 60 + tareas * 40);

        }

    }
}