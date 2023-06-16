using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_AND___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p, q;

            p = true;
            q = false;

            Console.WriteLine(p && q);

            byte edad;
            bool licencia;

            //preguntamos al usuario la edad
            Console.Write("¿Qué edad tienes?: ");
            edad = Convert.ToByte(Console.ReadLine());

            //preguntamos al usuario si tiene licencia de conducción
            Console.Write("¿Tienes licencia de conducción?: ");
            licencia = Convert.ToBoolean(Console.ReadLine());

            //verificamos si tiene la mayoría de edad
            if (edad >= 18 && licencia == true)
            {
                Console.WriteLine("Puedes conducir");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }

        }
    }
}
