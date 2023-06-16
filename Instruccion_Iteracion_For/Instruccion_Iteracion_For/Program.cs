using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruccion_Iteracion_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * sintaxis de un ciclo for
             * for(inicializador, condición, iterador)
             * {
             *    aquí código a repetirse
             * }
             */

            //variable de bucle o de control
            int i;

            for(i = 1;  i <= 10; i++)    
            { 
              Console.WriteLine(i); 
            }

            /*
             * Declaración e inicialización de una variable de control
             * Una instrucción de asignación
             */

            for(int a = 2; a <= 12; a++)
            {
                Console.WriteLine(a);
            }

            int b;

            for ( b = 3, Console.WriteLine("Valor inicial de la variable: {0}", b); b <= 24; b++)
            {
                Console.WriteLine(b);
            }

        }
    }
}
