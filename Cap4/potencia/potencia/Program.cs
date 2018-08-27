using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int numero;
            int potencia;
            float resultado;
            //capturado  datos
            Console.WriteLine("Introdusca el numero...");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdusca su potencia");
            potencia = Convert.ToInt32(Console.ReadLine());
            //imprimiendo datos
            resultado = (numero ^ potencia);
            Console.WriteLine("El resultado es: {0}",resultado);

        }
    }
}
