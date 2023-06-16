using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuando_Usar_Intrucciones_Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            double calificacion1, calificacion2, calificacion3, promedio;

            //preguntamos al usuario el primer resultado de la calificación
            Console.Write("Digita la calificación del primer alumno: ");
            calificacion1 = Convert.ToDouble(Console.ReadLine());

            //preguntamos al usuario el segundo resultado de la calificación
            Console.Write("Digita la calificación del segundo alumno: ");
            calificacion2 = Convert.ToDouble(Console.ReadLine());

            //preguntamos al usuario el tercer resultado de la calficación
            Console.Write("Digita la calificación del tercer alumno: ");
            calificacion3 = Convert.ToDouble(Console.ReadLine());

            //calculamos el promedio
            promedio = (calificacion1 + calificacion2 + calificacion3) / 3;

            //mostramos el promedio
            Console.WriteLine("El promedio es: {0}", promedio);

            /*
             * Si necesitamos saber el resultado de muchas calificaciones
             * tendriamos que agregar mucho código y la tarea sería repetitiva
             * lo cúal no es bueno para el programa, así que tendríamos que usar un ciclo for
             */

        }
    }
}
