using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTarea4Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1. Desarrollar un programa que calcule la potencia, ya sea negativa ó positiva 
             * de cualquier exponente.
             * 2. Desarrollar un programa que calcule los números primos entre el 1 y el 100
             */

            //variables
            int numero, divisor, numDivisores = 0;

            //bucle exterior, se encarga de recorrer los números del 2 al 100
            for(numero = 2; numero <= 100;  numero++) 
            {
                //bucle anidado, se encarga de verificar  el número de divisores
               for(divisor = 1; divisor <= numero; divisor++) 
                {
                   if(numero % divisor == 0)
                    {
                        numDivisores += 1; //numDivisores = numDivisores +1
                    }
                }

               //verificamos que el número de divisores sea igual a 2
               if(numDivisores <= 2)
                {
                    Console.WriteLine(numero);
                }

                //reiniciamos el conteo del número de divisores
                numDivisores = 0;
            }
        }
    }
}
