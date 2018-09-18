using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionSalon
{
    class Program
    {
        //programa que calcula la notas por curso
        static void Main(string[] args)
        {
            //variables necesarias
            int cantidad = 0; //cantidad de alumnos
            int salon = 0; //cantidad de salos de clases
            int n = 0;//variable de control de ciclo de salon
            int m = 0;//variable de control de ciclo de alumnos
            string valor = "";
            //variable para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minimo = 10.0f;
            float maximo = 0.0f;

            //pedimos la cantidad de salones
            Console.WriteLine("Dame la cantidad de salones");
            salon = Convert.ToInt32(Console.ReadLine());
            //pedimos la cantidad de alumnos
            Console.WriteLine("Dame la cantidad de Alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());
            //creamos el arreglo
            float[,] calif = new float[salon,cantidad];
            //capturamos la informacion
            for (n=0;n<salon;n++)//ciclo de salones
            {
                Console.WriteLine("Salon {0}",(n+1));
                for (m=0; m<cantidad; m++)//ciclo de alumno
                {
                    Console.WriteLine("Dame la calificacion de del alumno {0}: ",(m+1));
                    //colocando nota a cada salon y alumno
                    calif[n,m] = Convert.ToSingle(Console.ReadLine());
                }
            }
            //encontramos el promedio
            for (n=0;n<salon;n++)
            {
                for (m=0;m<cantidad; m++)
                {
                    suma += calif[n, m];
                }
            }
            promedio = suma / (cantidad * salon);
            //encontramos la calificacion minima
            for (n = 0; n < salon; n++)
            {
                for (m=0;m<cantidad;m++)
                {
                    if(calif[n,m] < minimo)
                    {
                        minimo = calif[n,m];
                    }
                }
            }
            //encontramos la calificacion maxima
            for (n=0;n<salon; n++)
            {
                for (m=0; m<cantidad;m++)
                {
                    if (calif[n,m]>maximo)
                    {
                        maximo = calif[n, m];
                    }
                }
            }
            //imprimiendo resultados
            Console.WriteLine("El promedio es: {0}",promedio);
            Console.WriteLine("La nota Mayor es: {0}", maximo);
            Console.WriteLine("La nota menor es: {0}",minimo);
        }//final del metodo main
    }
}
