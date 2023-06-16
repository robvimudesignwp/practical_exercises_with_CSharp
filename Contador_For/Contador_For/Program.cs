using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int contador = 0;

            for(i = 0; i <= 20; i+=2) 
            {
                contador += 1; //contador + 1 ó contador += 1
                Console.WriteLine("{0}, Vuelta del ciclo número {1}", i, contador);
            }

            Console.WriteLine("El número de vueltas que dió el ciclo fue: {0}", contador);

        }
    }
}
