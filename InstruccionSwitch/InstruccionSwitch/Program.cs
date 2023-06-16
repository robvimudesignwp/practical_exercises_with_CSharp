using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable
            String color;

            //pedimos al usuario que escriba el color
            Console.Write("Ingresa el color RGB para darte su código: ");
            color = Console.ReadLine();

            //verificamos que color ha digitado el usuario
            switch (color) 
            {
                case "Red":
                case "red"://case sensitive minúsculas
                case "RED"://case sensitive mayúsculas
                    Console.WriteLine("El código RGB para {0} es: 255, 0, 0", color);
                    break;

                case "Green":
                case "green":
                case "GREEN":
                    Console.WriteLine("El código RGB para {0} es: 0, 255, 0", color);
                    break;

                case "Blue":
                case "blue":
                case "BLUE":
                    Console.WriteLine("El código RGB para {0} es: 0, 0, 255", color);
                    break;
                default://cumple la misma función de un else
                    Console.WriteLine("No se encontró  el código RGB para el color {0}, intenta de nuevo", color);
                    break;
            }

        }
    }
}
