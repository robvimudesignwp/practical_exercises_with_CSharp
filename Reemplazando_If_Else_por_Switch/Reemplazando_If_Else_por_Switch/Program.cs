using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reemplazando_If_Else_por_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*crear un programa que permita al usuario escoger una de las 4 operaciones
             * básicas: suma, resta, multiplicación, división
             */

            //variables
            decimal numero1, numero2, resultado=0.0M;
            byte opcion;

            //mostramos el menú de opciones al usuario
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            //pedimos al usuario que eliga una de las opciones del menú
            Console.Write("Escoge una opción del menú: ");
            opcion = Convert.ToByte(Console.ReadLine());

            //pedimos al usuario que digite el primer número
            Console.Write("Escribe el primer número: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            //pedimos al usuario que digite el segundo número
            Console.Write("Escribe el segundo número: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    if(numero2 != 0)
                    {
                       resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir entre cero");
                    }
                    break;
                default:
                    Console.WriteLine("Ingresa una opción valida");
                    break;
            }

            //mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
