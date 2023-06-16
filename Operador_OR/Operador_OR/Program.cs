using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_OR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool r, g;

            r = false;
            g = false;

            Console.WriteLine(r || g);

            //variables
            float notaExamen, notaPreparatoria;

            //preguntamos al usuario su calificación de preparatoria 
            Console.Write("¿Con qué promedio concluiste tus estudios?: ");
            notaPreparatoria = Convert.ToSingle(Console.ReadLine());

            //preguntamos al usuario su calificación de examen
            Console.Write("Digita la calificación de tu examen de ingreso: ");
            notaExamen = Convert.ToSingle(Console.ReadLine());

            //validamos si es merecedor de la beca según sus respuestas
            if ((notaPreparatoria >= 9) || (notaExamen >= 9.5))
            {
                Console.WriteLine("¡Felicidades obtuviste la beca!");
            }
            else 
            {
                Console.WriteLine("Lo sentimos, no lograste obtener la beca");
            }
        }
    }
}
