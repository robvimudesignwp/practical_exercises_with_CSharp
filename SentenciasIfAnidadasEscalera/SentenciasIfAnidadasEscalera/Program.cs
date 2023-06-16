using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciasIfAnidadasEscalera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            decimal numero1, numero2, resultado = 0m;
            byte opcion;

            //mostramos las opciones al usuario
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicación");
            Console.WriteLine("4.División");

            //pedimos al usuario que escoja una opción del menú
            Console.Write("Escoge una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            //pedimos al usuario que dígite el primer número
            Console.Write("Dígite el primer número: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            //pedimos al usuario que dígite el segundo número
            Console.Write("Dígite el segundo número: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            //validamos cada opción del menú
            if (opcion == 1)
            {
                resultado = numero1 + numero2;
            }
            else
            {
                //resta
                if (opcion == 2)
                {
                    resultado = numero1 - numero2;
                }
                else
                {
                    //multiplicación
                    if (opcion == 3)
                    {
                        resultado = numero1 * numero2;
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            if (numero2 != 0)
                            {
                                resultado = numero1 / numero2;
                            }
                            else
                            {
                                Console.WriteLine("No es posible dividir entre 0");
                            }
                        }
                    }
                }
            }
            //mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado);

            /**
             * Operadores lógicos booleanos
             * ! Negación lógica
             * & AND Lógico
             * | OR Lógico
             * ^ OR exclusivo lógico
             * && AND lógico condicional
             * || OR lógico condicional
             */
        }
    }
}
