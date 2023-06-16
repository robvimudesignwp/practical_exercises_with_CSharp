using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaSeccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Realizar un programa de computadora que haga el cálculo
             * del área y perímetro de un rectángulo
             */

            //definimos variables
            double altura, ancho, perimetro, area;

            //solicitamos la altura y convertimos a tipo double
            Console.Write("Ingresa la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //solicitamos el ancho y convertimos a tipo double
            Console.Write("Ingresa el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            //calculamos el área
            area = altura * ancho;

            //calculamos el perímetro
            perimetro = 2*(altura + ancho);

            //mostramos los resultados en pantalla
            Console.WriteLine("El área es: {0}", area);
            Console.WriteLine("El perímetro es: {0}", perimetro);
        }
    }
}
