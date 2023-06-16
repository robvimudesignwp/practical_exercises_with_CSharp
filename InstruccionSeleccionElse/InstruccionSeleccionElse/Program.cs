using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionSeleccionElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //desarrollar un programa que verifique si alguién es mayor de edad

            //declaramos variables
            byte edad;

            //pedimos al usuario que ingrese su edad
            Console.Write("¿Qué edad tienes?: ");
            edad = Convert.ToByte(Console.ReadLine());

            //verificamos si es mayor o menor de edad
            if (edad >= 18) 
            {
                //se ejecuta si la condición es true
                Console.WriteLine("Eres mayor de edad");
            }
            else 
            {
                //se ejecuta si la condición es false
                Console.WriteLine("Eres menor de edad");
            }
        }
    }
}
