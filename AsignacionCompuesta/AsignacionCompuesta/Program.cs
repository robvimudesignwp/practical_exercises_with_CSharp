using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionCompuesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = x + 5; //asignación compuesta por operador aritmético ( +, -, *, /)
            y += 7; // sería igual que escribir y = y + 7
            Console.WriteLine(x);
            Console.WriteLine(y);

            /*
             * +----------------------+------------------+-------------------------+
             * | Asignación Compuesta |  Formato x op= y | Equivalencia x = x op y |
             * +----------------------+------------------+-------------------------+
             * |        +=            |      x += y      |       x = x + y         |
             * +----------------------+------------------+-------------------------+
             * |        -=            |      x -= y      |       x = x - y         |
             * +----------------------+------------------+-------------------------+
             * |        *=            |      x *= y      |       x = x * y         |
             * +----------------------+------------------+-------------------------+
             * |        /=            |      x /= y      |       x = x / y         |
             * +----------------------+------------------+-------------------------+
             */
        }
    }
}
