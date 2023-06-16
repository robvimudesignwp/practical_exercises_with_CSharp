using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionSeleccionIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instrucciones de selección if, else, switch, case

            //Pedir un número al usuario y determinar si esto es positivo o negativo

            //declaramos la variable
            double numero;

            //Pedimos al usuario que digite un número
            Console.Write("Escribe un número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            //Usamos el condicional If para saber si el número digitado es mayor que cero
            if (numero > 0)
            {
                //se ejecuta si la expresión se evalua como true
                Console.WriteLine("El número es positivo");
            }   
            
            if (numero < 0) 
            {
                //se ejecuta si la expresión se evalue como false
                Console.WriteLine("El número es negativo");
            }

            //multiples sentencias if

            //desarrollar un programa que haga la división entre dos números

            //definimos las variables
            double dividendo, divisor, resultado;

            //pedimos al usuario que ingrese un dividendo
            Console.Write("Escribe un número dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            //pedimos al usuario que ingrese un divisor
            Console.Write("Escribe un número divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            //hacemos la comprobación con la condicional if
            if (divisor != 0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("{0} / {1} = {2}",dividendo, divisor, resultado);
            }

        }
    }
}
