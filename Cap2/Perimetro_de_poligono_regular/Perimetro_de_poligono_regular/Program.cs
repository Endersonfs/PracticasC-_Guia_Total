using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro_de_poligono_regular
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************
             * Observacion:
             * Sumando las longitudes 
             * los lados de un polígono
             * hallaremos su perímetro
             * *************************/

            //variables
            double perimetro =0.0f;
            int lados = 0;
            double cm = 0.0f;

            Console.WriteLine("Introduce el numero de lados");
            lados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el centrimeto de uno de sus lados");
            cm = Convert.ToDouble(Console.ReadLine());
            perimetro= (lados*cm);
            //imprimiendo perimetro
            Console.WriteLine("El perimetro del poligo Regular es: {0}",perimetro);
        }
    }
}
