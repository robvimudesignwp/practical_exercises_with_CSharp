using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Multiplicación, División, Módulo
             * Suma, Resta
             * Parentesis tiene mayor gerarquía 
             */

            double operacion1;
            operacion1 = (8 / 3) + (5 * 6);

            double operacion2;
            operacion2 = 5 / (9 + 7) * 4 - 3;

            double operacion3;
            operacion3 = 9 * 4 + 8 - (5 / 4 - 6);

            Console.WriteLine(5 * 4 + 6); 
            Console.WriteLine(3 / 3 + 5 * 2);
            Console.WriteLine(operacion1);
            Console.WriteLine(operacion2);
            Console.WriteLine(operacion3);
        }
    }
}
