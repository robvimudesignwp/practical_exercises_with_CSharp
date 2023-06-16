using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumulador_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Asignación compuesta (x -= 5) == (x = x - 5)
             * Acumulador = acumulador + variable == variable += variable
             */

            int i;
            int acumulador = 0;
            int precio;

            for(i = 1; i <= 5; i++) 
            {
                Console.Write("Ingresa el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + precio; //de esta forma también se podría acumulador += precio;
            }

            Console.WriteLine("El precio total es: {0}", acumulador);

        }
    }
}
