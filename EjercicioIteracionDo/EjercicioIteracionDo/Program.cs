using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIteracionDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            decimal numero1, numero2, resultado = 0M;
            byte opcion; //podemos ingresar valores negativos cambiando de byte a int

            do
            {
                //Mostramos el menú de opciones al usuario
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                //Pedimos al usuario que digite la opción escogida
                Console.Write("Elije una opción del menú: ");
                opcion = Convert.ToByte(Console.ReadLine());
            }

            while ((opcion < 1) || (opcion > 4));

            //Pedimos al usuario que digite los números para hacer la operación según escoja
            Console.Write("Digita el primer número: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digita el segundo número: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            //Realizamos la operación matemática según la opción escogida por el usuario
            switch(opcion)
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
                        Console.WriteLine("No es posible dividir entre 0");
                    }
                    break;
            }

            Console.WriteLine("El resultado es: {0} ", resultado);
        }
    }
}
