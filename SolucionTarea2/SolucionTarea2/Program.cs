using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //desarrollar un programa que calcule el perímetro de cualquier polígono regular
            int numeroLados;
            double tamanoLado, perimetro;

            //pedimos al usuario que digite el número de lados del polígono
            Console.Write("Escribe el número de lados que tiene el polígono: ");
            numeroLados = Convert.ToInt32(Console.ReadLine());

            //pedimos al usuario que digite la médida de uno de los lados del polígono
            Console.Write("Escribe la médida de uno de los lados del polígono: ");
            tamanoLado = Convert.ToDouble(Console.ReadLine());

            //calculamos el perímetro del polígono
            perimetro = numeroLados * tamanoLado;

            //mostramos el resultado 
            Console.WriteLine("El perímetro del polígono es: {0}", perimetro);

        }
    }
}
