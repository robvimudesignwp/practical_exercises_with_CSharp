using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Calcular_Precio_Estacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*desarrollar un programa que le permita saber al usuario
             * el precio que debe pagar por el servicio de estacinamiento
             * de un centro comercial con base en el tiempo que ha permanecido ahí
             * los primeros 60 minutos $5.00, las primeras 2 horas $15.00
             * y de dos horas en adelante $40.00
             * */

            //variable
            float minutos;

            /*pedimos al usuario que ingrese la cantidad de tiempo que estuvo en
             * el estacionamiento
             */
            Console.Write("Ingresa el tiempo que estuviste en el estacionamiento (minutos): ");
            minutos = Convert.ToSingle(Console.ReadLine());

            //verificamos el costo según la cantidad del tiempo en el estacionamiento
            if(minutos >= 0 && minutos <= 60) 
            {
                Console.WriteLine("Debes cancelar el valor de $5.00 por favor");
            }
            else  
            {
                if ((minutos > 60) && (minutos <= 120)) //podemos encerrar los operandos en () 
                {
                    Console.WriteLine("Debes cancelar el valor de $15.00 por favor");
                }
                else 
                {
                   if(minutos > 120)
                    {
                        Console.WriteLine("Debes cancelar el valor de $40.00");
                    }
                }
            }
        }
    }
}
