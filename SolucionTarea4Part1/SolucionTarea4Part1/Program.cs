using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTarea4Part1
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
            int numero, exponente, i;
            double resultado = 1, resultadoNegativo;

            //pedimos al usuario que digite el numero
            Console.Write("Ingresa el número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //pedimos al usuario que digite el exponente
            Console.Write("Ingresa el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            //validamos si el exponente es positivo o negativo
            if(exponente < 0 ) 
            {
                //convertimos el exponente a positivo
                exponente *= -1;

                for(i = 1; i <= exponente; i++) 
                {
                    resultado *= numero;
                }

                //asignamos a resultado negativo
                resultadoNegativo = (1 / resultado);

                //mostramos el resultado al usuario
                Console.WriteLine("{0} ^ {1} = {2}", numero, exponente, resultadoNegativo);
            }
            else 
            {
                for(i = 1;i <= exponente; i++) 
                {
                    resultado *= numero;
                }

                //mostramos el resultado al usuario
                Console.WriteLine("{0} ^ {1} = {2}", numero, exponente, resultado);
            }
        }
    }
}
