using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. precalentar el horno");
            Console.WriteLine("2. mezclar harina y mantequilla");
            Console.WriteLine("3. agregar azúcar y 1 huevo");
            Console.WriteLine("4. amasar la mezcla");
            Console.WriteLine("5. darles forma y colocar en el molde");
            Console.WriteLine("6. hornear durante 10 minutos");
            Console.Write("7. servir en la mesa"); // Write quita salto de linea
            Console.WriteLine("8. masticar");//WriteLine agrega un salto de linea

            int numeroLibros;
            int librosInfantiles;
            int librosMatematicas;

            int librosFinanzas, librosInformatica, librosIngles; // declarar variables en una sola linea 

            double promedioNotaFinal;

            numeroLibros = 500; //inicializar variables

            char salon;

            salon = 'B';

            String saludo = "Hola amigos";

            bool Z = true;

            decimal notaFinal = 4.5M;

            float promedioCalificaciones = 7.5F;

            //Esto es un comentario de una sola linea en C#
            /**
             * Este es un comentario multilinea en 
             * C# 
             */

            Console.WriteLine(saludo); // mostrando el valor de una variable
            Console.WriteLine(salon);

            double precioZapatos = 99;
            String colorZapatos = "Negros";
            Console.WriteLine("El precio de los zapatos es: {0} y su color es: {1}", precioZapatos, colorZapatos);

            Console.WriteLine(5 + 5); //Sumamos dos números

            int numero1 = 12;
            double numero2 = 7.6;

            Console.WriteLine(numero1 * numero2); //multiplicamos los 2 valores de las variables

            int numero3 = 9;
            double numero4 = 13.5;
            double resultado;
            double resultado2; 

            resultado = numero3 + numero4; //sumamos dos variables y agregamos el resultado en una variable
            resultado2 = numero4 / 87.6; //sumamos una variable más un número decimal

            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);

            String mensajeBienvenida = "Bienvenido";
            String nombrePersona = "Robert";

            Console.WriteLine(mensajeBienvenida + nombrePersona); //sumamos dos Strings almacenadas en variables concatenamos con +

            Console.WriteLine(mensajeBienvenida + " " + nombrePersona + " " + "¿Cómo estas?"); //agregamos un string por aparte

            int numero5 = 13;
            double numero6 = 2.0;
            float numero7 = 16.8f; //sufijo F ó f float 
            float numero8 = 4.1f;
            double numero9 = 16.8;
            double numero10 = 4.1;
            decimal numero11 = 16.8m; //sufijo M ó m decimal
            decimal numero12 = 4.1m;

            Console.WriteLine(numero5 / numero6);
            Console.WriteLine(numero7 / numero8);
            Console.WriteLine(numero9 / numero10);
            Console.WriteLine(numero11 / numero12);

            decimal numero13 = 5.9m;
            decimal numero14 = 3.1m;

            Console.WriteLine(numero13 % numero14);


        }
    }
}
