using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionIteracionDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * do
             * {
             * hacer
             * }
             * while (condición)
             * {
             * mientras
             * }
             */

            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10); 
        }
    }
}
