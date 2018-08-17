using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBase3
{
    class Program
    {
        //esta es la funcion principal del programa
        //aqui inicia la aplicacion
        static void Main(string[] args)
        {
            //declaramos variables
            int costos;
            int valor, precio;

            //inicializamos la variables
            costos = 50;
            valor = 75;
            precio = 125;

            //declaramos e inicializamos
            int impuesto = 10;

            //mostrar un valor
            Console.WriteLine("Valor es {0}", costos);

            //varias variables
            Console.WriteLine("Valor es {0} y precio es {1}", valor, precio);

            //dos veces la misma variable 
            Console.WriteLine("Valor es {0} y precio es {1} con valor de {0}", valor,precio);
            /*no olvidemos
             mostrar el valor de la 
             variable impuesto*/

            Console.WriteLine("y el valor que nos faltaba mostrar {0}",impuesto);
        }
    }
}
