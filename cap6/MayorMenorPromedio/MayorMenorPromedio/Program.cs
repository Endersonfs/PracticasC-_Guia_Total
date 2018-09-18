using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorMenorPromedio
{
    class Program
    {
        /*Programa para encontral el promedio la nota mayor
         y la nota menor*/
        static void Main(string[] args)
        {
            //variables necesarias
            int cantidad=0;
            int n =0;
            string valor = "";
            //variables para el promedio
            float promedio=0.0f;
            float suma = 0.0f;
            float minimo = 10.0f;
            float maximo = 0.0f;
            //captura de datos
            Console.WriteLine("Cantidad de Alumno");
            cantidad = Convert.ToInt32(Console.ReadLine());
            //creamos el arreglo
            float[] calif = new float[cantidad];
            //capturando la informacion
            for (int i=0;i<cantidad;i++)
            {
                Console.WriteLine("Dame nota el alumno {0}",(i+1));
                calif[i] = Convert.ToSingle(Console.ReadLine());
            }//final del if
            //encontrando el promedio
            for (int i = 0; i < cantidad; i++)
            {
                suma += cantidad;
            }
            promedio = suma / cantidad;
            //encontrando el mayor numero
            for (int i=0;i<cantidad;i++)
            {
                if (calif[i] > maximo )
                {
                    maximo = calif[i];
                }
            }
            //encontrando menor numero
            for (int i=0;i<cantidad;i++)
            {
                if (calif[i] < minimo )
                {
                    minimo = calif[i];
                }
            }
            Console.WriteLine("La calificacion maxima es: {0}",maximo);
            Console.WriteLine("La Calificacion minima es: {0}",minimo);
            Console.WriteLine("El promedio es: {0}",promedio);

        }
    }
}
