using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresComparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * < menor que
             * > mayor que
             * <= Menor e igual que
             * >= Mayor e igual que
             **/

            double a = 3.5, b = 8.7;
            double c = 9.5, d = 7.3;
            double e = 6.4, f = 0.5;
            int g = 3, h = 7;

            Console.WriteLine(a >= b);
            Console.WriteLine(a <= c);
            Console.WriteLine(a > d);
            Console.WriteLine(b < f);
            Console.WriteLine(c > e);
            Console.WriteLine(d > g);
            Console.WriteLine(e > h);
            Console.WriteLine((a + d) >= g);
            Console.WriteLine((b * f) - h <= a);
        }
    }
}
