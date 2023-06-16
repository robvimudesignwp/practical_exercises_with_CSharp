using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_Negacion__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = false;
            bool bateria;

            Console.WriteLine(p); //mostrara true en consola
            Console.WriteLine(!p); // se convertirá a false en consola al agregarle el signo !

            Console.WriteLine("¿Hay batería aún? (true/false): ");
            bateria = Convert.ToBoolean(Console.ReadLine());

            if (!(bateria == true))
            {
                Console.WriteLine("Conecta el celular");
            }
            else
            {
                Console.WriteLine("¡Aún hay buen porcentaje de batería!");
            }
        }
    }
}
