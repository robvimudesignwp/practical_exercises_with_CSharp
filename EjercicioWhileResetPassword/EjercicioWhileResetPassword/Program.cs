using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWhileResetPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            String password1, password2 = "";

            //Pedimos al usuario que digite su nueva contraseña
            Console.Write("Por favor escribe tu nueva contraseña: ");
            password1 = Console.ReadLine();

            while(password1 != password2) 
            {
                Console.Write("Confirma tu contraseña: ");
                password2 = Console.ReadLine();
            }

            Console.WriteLine("¡Contraseña guardada con exito!.. ");

        }
    }
}
