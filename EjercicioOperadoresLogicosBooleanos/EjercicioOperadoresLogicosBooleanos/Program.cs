using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOperadoresLogicosBooleanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            float energia;
            bool propulsorLeft, propulsorRight;

            //pedimos al piloto que ingrese el nivel de energía
            Console.Write("Ingrese el nivel de energia de la nave: ");
            energia = Convert.ToSingle(Console.ReadLine());

            //preguntamos al piloto el estado del propulsor izquierdo
            Console.Write("¿El propulsor izquierdo está en buen estado? (true/false): ");
            propulsorLeft = Convert.ToBoolean(Console.ReadLine());

            //preguntamos al piloto el estado del propulsor derecho
            Console.Write("¿El propulsor derecho está en buen estado? (true/false): ");
            propulsorRight = Convert.ToBoolean(Console.ReadLine());

            //validamos cada respuesta dada por el piloto
            if ((propulsorRight && propulsorLeft == true && energia >= 75) || (propulsorRight || propulsorLeft == true && energia == 100))
            {
                Console.WriteLine("¡Excelente, puedes despegar la nave!");
            }
            else 
            {
                Console.WriteLine("¡Lo siento, no puedes despegar la nave!");
            }
        }
    }
}
