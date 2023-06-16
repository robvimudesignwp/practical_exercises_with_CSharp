using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionIteracionAnidada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int i; //variable encargada del bucle exterior
            int j; //variable encargada del bucle interior/anidada
            int resultado; //variable que guarda el valor de la multiplicación
            
            for(i=1; i<=10; i++) //bucle exterior/externo
            {
              Console.WriteLine("Tabla de multiplicar del {0}", i);

                for(j=1; j<=10; j++);
                {
                    resultado = i * j;

                    Console.WriteLine("{0} * {1} = {2}", i, j, resultado);
                }
            }

            Console.ReadKey();
        }
    }
}
