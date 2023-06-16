using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresIncrementoDecremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  *---------------------------------------------------*
             *  |    Operador   |   Signo  |  Prefijo  |  Sufijo    |
             *  *---------------------------------------------------*
             *  |   Incremento  |    ++    |    ++¡    |   ¡++      |
             *  *---------------------------------------------------*
             *  |   Decremento  |    --    |    --¡    |   ¡--      |
             *  *---------------------------------------------------*
             */

            int i; //operando
            i = 10;

            Console.WriteLine("Valor inicial del operando: {0}", i);

            //Incremento como sufijo e imprimimos en pantalla
            Console.WriteLine("Valor con incremento incluido: {0}", i++);

            //Incremento como prefijo e imprimimos en pantalla
            Console.WriteLine("Valor con incremento incluido: {0}", ++i);

            //Ya no incrementamos, solo imprimimos
            Console.WriteLine(i);

            int n = 20;

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Valor inicial del operando: {0}", n);

            //Decremento como sufijo e imprimimos en pantalla
            Console.WriteLine("Valor con decremento incluido: {0}", n--);

            //Decremento con prefijo e imprimimos en pantalla
            Console.WriteLine("Valor con decremento incluido: {0}", --n);
        }
    }
}
