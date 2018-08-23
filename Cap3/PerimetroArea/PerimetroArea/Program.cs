using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int valor = 0;

            Console.WriteLine("Elija el numero de la Opcion");
            Console.WriteLine("1. Perimetro");
            Console.WriteLine("2. Area");
            //capturando datos
            valor = Convert.ToInt32(Console.ReadLine());
            //toma de desiciones
            if (valor != 1 && valor != 2)
            {
                Console.WriteLine("Debe introducir un valor que este entre 1 y 2");
            }
            else
            {
                if (valor == 1)
                {
                    /*Observacion
                     * Perímetro = número de lados multiplicado por longitud del lado.
                     */

                    //variable
                    int lado;
                    float longitud;
                    float Resultado;
                    //imprimiendo opciones
                    Console.WriteLine("Introdusca el numero de lados");
                    lado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introdusca la longitud de uno de sus lados.");
                    longitud = Convert.ToSingle(Console.ReadLine());

                    Resultado = lado * longitud;

                    Console.WriteLine("El perimeto es, {0}", Resultado);
                    
                }
                else
                {
                    /*Observacion
                     * El área de un polígono regular es igual al producto de su perímetro por su apotema dividido entre dos.
                     */
                    //variables
                    int lados;
                    float longitud;
                    float perimetro;
                    float area;
                    //capturando datos
                    Console.WriteLine("Introdusca el numero de lados");
                    lados = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introdusca la longitud de uno de sus lados");
                    longitud = Convert.ToInt32(Console.ReadLine());
                    perimetro = (lados * longitud);

                    //imprimendo el area
                    area = Convert.ToSingle((perimetro*longitud)/2);
                    Console.WriteLine("El area del poligono regular es, {0}",area);
                }
            }
        }
    }
}
