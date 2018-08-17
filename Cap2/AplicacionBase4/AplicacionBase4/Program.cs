using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBase4
{
    class Program
    {
        //esta es la funcion principal del programa
        //aqui inicia la aplicacion
        static void Main(string[] args)
        {
            //declaramo la variable ahora de tipo flotante
            float a, b, resultado;

            //inicializamos las variables
            a = 7;
            b = 8;
            resultado = 0;

            //sumas
            Console.WriteLine("Suma");
            resultado = 3 + 5;
            Console.WriteLine("Resultado {0}", resultado);

            resultado = a + 3;
            Console.WriteLine("Resultado {0}", resultado);

            resultado = b + a;
            Console.WriteLine("Resultado {0}", resultado);

            //restas
            Console.WriteLine("Restas");
            resultado = a - b;
            Console.WriteLine("Resultado {0}", resultado);

            resultado = b - 5;
            Console.WriteLine("Resultado {0}", resultado);

            resultado = b -a; //a la variable b se le resta a
            Console.WriteLine("Resultado {0}", resultado);
            //mutliplicacion
            Console.WriteLine("Multiplicaciones");
            resultado = a * 5;
            Console.WriteLine("Resultado {0}", resultado);

            resultado = a * 3.5f;
            Console.WriteLine("Resultado {0}", resultado);

            resultado = a * b;
            Console.WriteLine("Resultado {0}", resultado);

            //divisiones
            Console.WriteLine("Divisiones");
            resultado = a / 3;
            Console.WriteLine("Resultado {0}", resultado);

            resultado = a / b;
            Console.WriteLine("Resultado {0}", resultado);

            resultado = b / 2.5f;
            Console.WriteLine("Resultado {0}", resultado);

            //modulo
            Console.WriteLine("Modulo");
            resultado = a % b;
            Console.WriteLine("Resultado {0}", resultado);

        }
    }
}
