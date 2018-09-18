using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionSalon2
{
    class Program
    {
        //prgrma de salones con diferentes cantidades de alumnos
        static void Main(string[] args)
        {
            //variables necesarias
            int salon = 0;
            int cantidad=0;
            int n = 0;
            int m = 0;
            //variable para el promedio
            float promedio = 0.0f;
            float maximo = 0.0f;
            float minimo = 10.0f;
            //pedimos la cantidad de salones
            Console.WriteLine("Dame la cantidad de salones");
            salon = Convert.ToInt32(Console.ReadLine());
            //creamos en arreglo
            float[][] calif = new float[salon][];
            //pedimos los alumnos por salon
            for (n = 0; n < salon; n++)
            {
                Console.WriteLine("Dame la cantidad de alumna para el  aula {0}", (n+1));
                cantidad = Convert.ToInt32(Console.ReadLine());
                //instanciameos el arreglo
                calif[n] = new float[cantidad];
            }
            //capturamos la informacion
            for (n=0;n<salon;n++)
            {
                Console.WriteLine("Salon {0}",(n+1));
                for (m=0;m<calif[n].GetLength(0);m++)
                {
                    Console.WriteLine("Dame la calificacion");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }
            //desplegamos la informacion
            Console.WriteLine("------------------Informacion------------------");
            for (n=0;n<salon;n++)
            {
                Console.WriteLine("Salon {0}",(n+1));
                for (m=0;m<calif[n].GetLength(0);m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1}",m,calif[n][m]);
                }
            }

        }
    }
}
