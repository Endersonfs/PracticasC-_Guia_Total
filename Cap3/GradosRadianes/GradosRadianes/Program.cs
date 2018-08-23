using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * problema
 *  Hacer un programa que transforme de
    grados a radianes o de radianes a grados
    dependiendo de lo que necesite el
    usuario
 */
namespace GradosRadianes
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato = 0;
            float resultado = 0.0f;
            //introducir datos
            Console.WriteLine("Que Deceas Hacer?");
            Console.WriteLine("1. Convertir de Grados a Radianes");
            Console.WriteLine("2. Convertir de Radianes a Grados");
            Console.WriteLine("Introdusca el numero de la opcion");
            //capturando datos
            dato = Convert.ToInt32(Console.ReadLine());
            //toma de desiciones
            if (dato != 1 && dato != 2)
            {
                Console.WriteLine("Introdusca Su Un valor que este en la opciones");
            }
            else
            {
                if (dato == 1)
                {
                    float valor = 0.0f;
                    Console.WriteLine("Introdusca Su numero de Grados");
                    valor = Convert.ToSingle(Console.ReadLine());
                    resultado = Convert.ToSingle((valor / 180)*3.1416);
                    Console.WriteLine("Su valor en Radianes es, {0}", resultado);
                }
                else
                {
                    float valor = 0.0f;
                    Console.WriteLine("Introdusca su numero en Radianes");
                    valor = Convert.ToSingle(Console.ReadLine());
                    resultado = Convert.ToSingle((dato*180)/3.1416);
                    Console.WriteLine("Su valor en Grados es, {0}",resultado);
                }
            }
        }
    }
}
