using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int numero=0;
            int respuesta=0;
            //capturando datos
            Console.WriteLine("Introdusca tu numero para imprimir su tabla");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabla de Multiplicar del numero {0}",numero);
            for (int i=0; i<=10;i++)
            {
                respuesta = numero * i;
                Console.WriteLine("{0}X{2} = {1}",numero,respuesta,i);
            }

        }
    }
}
