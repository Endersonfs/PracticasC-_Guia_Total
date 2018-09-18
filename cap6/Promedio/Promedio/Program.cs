using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        //programa de promedio utilizando jagged
        static void Main(string[] args)
        {
            //variables necesarias
            int salon =0;
            int alumnos=0;
            float resultado = 0;
            int resultadoAlumno = 0;

            //capturando valores
            Console.WriteLine("Dame la cantidad de salones");
            salon = Convert.ToInt32(Console.ReadLine());
            //declarando arreglo jagged
            float[][] calif = new float[salon][];
            //pedimos la cantidad de alumnos
            for (int i=0;i<salon;i++)
            {
                Console.WriteLine("Dame la cantidad de Alumnos para el salon {0}: ",(i+1));
                alumnos = Convert.ToInt32(Console.ReadLine());
                resultadoAlumno *= alumnos;
                //instanciamos el arreglo
                calif[i]= new float[alumnos];
            }
            //almacenando la nota
            for (int i=0;i<salon;i++)
            {
                for (int a=0; a<calif[i].GetLength(0);a++)
                {
                    Console.Write("Dame la nota del alumno {0}  del salon {1} = ",(a+1),(i+1));
                    calif[i][a]= Convert.ToSingle(Console.ReadLine());
                }
            }
            //mostrando informacion
            Console.WriteLine("----------------Informacion----------------");
            for (int i=0;i<salon;i++)
            {
                Console.WriteLine("El salon {0}",i);
                for (int m = 0; m < calif[i].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1}", (m+1),calif[i][m]);
                    resultado += calif[i][m];
                }
            }
            Console.WriteLine("Calif {0} ",resultado/(resultadoAlumno*salon));
        }
    }
}
