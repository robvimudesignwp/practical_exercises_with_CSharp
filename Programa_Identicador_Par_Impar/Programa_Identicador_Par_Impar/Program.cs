using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Identicador_Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*desarrollar un programa que le permita al usuario digitar un número
             * e identificas si es par ó impar
             */

            //variable
            long numero;

            //pedimos al usuario que digite  un número
            Console.Write("Digita un número y te diré si es par ó impar: ");
            numero = Convert.ToInt64(Console.ReadLine());

            //verificamos si el número digitado es par ó impar

            if(numero % 2 == 0) 
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
        }
    }
}
