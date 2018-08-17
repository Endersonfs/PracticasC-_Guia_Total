using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centígrados_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double grados =0.0;
            double a, b, c;
            double resultado=0.0;

            Console.WriteLine("Introduces Tu Grados celsius");
            grados = Convert.ToDouble(Console.ReadLine());

            //formula
            a = grados * 2;
            b = a*0.1;
            c = a - b;
            resultado = c + 32;

            Console.WriteLine("Tu Grados {0} en fahrenheit es {1} ",grados, resultado);
        }
    }
}
