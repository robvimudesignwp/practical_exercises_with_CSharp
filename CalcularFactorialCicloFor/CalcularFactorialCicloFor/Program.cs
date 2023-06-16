using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFactorialCicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 0! = 1
             * 1! = 1
             * 2! = 2*1 = 3
             * 3! = 3*2*1 = 6
             * 4! = 4*3*2*1 = 24
             * 5! = 5*4*3*2*1 = 120
             */

            //variables
            ulong i, numero, factorial = 1;

            //Pedimos al usuario que ingrese un número para calcular el factorial
            Console.Write("Ingresa un número para calcular su factorial: ");
            numero = Convert.ToUInt64(Console.ReadLine());

            //calculamos el factorial
            for (i = numero; i >= 1; i--) 
            {
              factorial = factorial * i; //factorial *= 1; 
            }

            Console.WriteLine("El factorial de {0} es: {1}",numero, factorial);
        }
    }
}
