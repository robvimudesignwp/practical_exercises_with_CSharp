using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTarea2Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //desarrollar un programa que transforme grados centigrados en fahrenheit

            //variables
            float gradosC, gradosF;

            //pedimos al usuario que digite los grados centigrados
            Console.Write("Escribe los °C: ");
            gradosC = Convert.ToSingle(Console.ReadLine());

            //convertimos los grados centigrados a fahrenheit
            gradosF = (gradosC * 1.8f) + 32;

            //mostramos el resultado
            Console.WriteLine("{0} °C = {1} °F", gradosC, gradosF);
        }
    }
}
