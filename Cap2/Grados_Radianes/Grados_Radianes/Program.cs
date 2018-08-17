using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados_Radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            double grados = 0.0;
            double resultado = 0;

            //entrada de datos
            Console.WriteLine("Introdusca su grado");
            grados = Convert.ToDouble(Console.ReadLine());

            //formular
            resultado = (grados / 180) * 3.1416;

            //imprimiendo resultado
            Console.WriteLine("Su Numero en Radianes es: {0}",resultado);
        }
    }
}
