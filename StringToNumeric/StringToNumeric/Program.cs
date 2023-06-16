using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToNumeric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convertir una cadena a tipo numerico
            String entrada1;
            int numero1 = 5, numero2, resultado1;

            //pedimos al usuario que digite un número
            Console.Write("Escribe un número para sumarlo: ");
            //se asigna a la variable de tipo string entrada1
            entrada1 = Console.ReadLine();

            //convertimos la cadena a un tipo int
            numero2 = Convert.ToInt32(entrada1);

            resultado1 = numero1 + numero2;

            //mostramos el resultado por pantalla
            Console.WriteLine("El resultado de la suma es: {0}", resultado1);

            String entrada2;
            int numero3 = 7, numero4, resultado2;
            //pedimos al usuario que digite un número
            Console.Write("Escribe un número para multiplicarlo: ");
            //se asigna a la variable de tipo string entrada2
            entrada2 = Console.ReadLine();

            numero4 = Int32.Parse(entrada2);

            resultado2 = numero3 * numero4;
            //mostramos el resultado por pantalla
            Console.WriteLine("El resultado de la multiplicación es: {0}", resultado2);


            //======== convertir una cadena sin usar variables de tipo String

            int numero5 = 9, numero6, resultado3;

            //preguntamos al usuario el número
            Console.Write("Escribe un número para dividirlo: ");

            numero6 = Convert.ToInt32(Console.ReadLine());

            resultado3 = numero5 / numero6;

            //mostramos el resultado por pantalla 
            Console.WriteLine("El resultado de la división es: {0}", resultado3);


            //====================================================================
            int numero7 = 6, numero8, resultado4;

            //preguntamos al usuario el número
            Console.Write("Escribe un número para restarlo: ");

            numero8 = Int32.Parse(Console.ReadLine());

            resultado4 = numero7 - numero8;

            //mostramos el resultado por pantalla
            Console.WriteLine("El resultado de la resta es: {0}", resultado4);
        }
    }
}
