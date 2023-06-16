using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secciones_For_Iterador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asignación compuesta (x -= 5) == (x = x - 5)

            int i;

            for(i = 1; i <= 10; i += 2) //iteramos de 2 en 2 con un operador de asignación compuesta
            {
              Console.WriteLine(i);
            }

            int c;

            for(c = 10; c >= 1; c --, Console.WriteLine("Valor de salida: {0}", c)) //decremento
            {
                Console.WriteLine(c);
            }
        }
    }
}
