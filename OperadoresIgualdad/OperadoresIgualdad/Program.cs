using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresIgualdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30, b = 20;
            int c = 9, d = 9;
            int e = 10, f = 8;

            Console.WriteLine(a != b); //arrojará true
            Console.WriteLine(c == d); //arrojará true
            Console.WriteLine(e == f); //arrojará false
        }
    }
}
