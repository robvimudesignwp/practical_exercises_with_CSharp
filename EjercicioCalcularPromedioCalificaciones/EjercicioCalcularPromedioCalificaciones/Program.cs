using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalcularPromedioCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* asignación compuesta (x -= 5) == (x = x - 5)
             * acumulador = acumulador + variable == acumulador += variable
             */

            byte i, numeroAlumnos;
            double calificacion, sumaCalificacion = 0, promedio;

            //pedimos al usuario que ingrese la cantidad de alumnos
            Console.Write("Ingresa el número de alumnos: ");
            numeroAlumnos = Convert.ToByte(Console.ReadLine());

            for(i = 1; i <= numeroAlumnos; i++) 
            {
                Console.Write("Ingresa la calificación: ");
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaCalificacion += calificacion;
            }

            //calculamos el promedio
            promedio = sumaCalificacion / numeroAlumnos;

            //mostramos el promedio
            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}
