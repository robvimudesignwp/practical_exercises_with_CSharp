using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedirDatosUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReadLine lee los caracteres que el usuario digita
            String nombre;
            //preguntamos el nombre al usuario
            Console.Write("¿Cómo te llamas?: ");
            nombre = Console.ReadLine();//obtenemos lo que el usuario digitó

            //saludamos al usuario 
            Console.WriteLine("Hola {0}, es un gusto saludarte", nombre);
        }
    }
}
