using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciasIfAnidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Se necesita un programa que realice las 4 operaciones básicas: suma, resta,
             * multiplicación y división, a partir de dos números, la operación deseada debe
             * ser elegida por el usuario
             */

            //variables
            decimal numero1, numero2, resultado = 0m;
            byte opcion;

            //mostramos las opciones al usuario
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicación");
            Console.WriteLine("4.División");

            //pedimos al usuario que elija una opción del menú
            Console.Write("Elige una opción del menú: ");
            opcion = Convert.ToByte(Console.ReadLine());

            //pedimos al usuario que ingrese el primer número
            Console.Write("Ingresa el primer número: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            //pedimos al usuario que ingrese el segundo número
            Console.Write("Ingresa el segundo número: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            //verificamos la opción escogida por el usuario para ejecutar la suma
            if (opcion == 1)
            {
                resultado = numero1 + numero2;
            }

            //verificamos la opción escogida por el usuario para ejecutar la resta
            if (opcion == 2) 
            {
               resultado = numero1 - numero2;
            }

            //verificamos la opción escogida por el usuario para ejecutar la multiplicación
            if (opcion == 3) 
            {
                resultado = numero1 * numero2;
            }

            //verificamos la opción escogida por el usuario para ejecutar la división con if anidado
            if (opcion == 4)
            {
                if (numero2 != 0) 
                {
                    resultado = numero1 / numero2;
                } 
                else
                {
                    Console.WriteLine("No es posible dividir entre cero");
                }
            }

            //mostramos el resultado al usuario
            Console.WriteLine("El resultado de la operación es: {0}", resultado);
        }
    }
}
