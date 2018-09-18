using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorNota
{
    class Program
    {
        //calculando la mayor nota de estudiantes utilizando jagged
        static void Main(string[] args)
        {
            //variables necesarias
            int cursos = 0;
            int estudiantes = 0;
            float notas = 0.0f;
            float maximo = 0.0f;
            Console.WriteLine("Numero de cursos");
            cursos = Convert.ToInt32(Console.ReadLine());
            //arreglo jagged
            float[][] calif = new float[cursos][];
            //
            for (int i=0;i<cursos;i++)//agregando estudiantes
            {
                Console.WriteLine("Cantidad de estudiante del curso {0}",(i+1));
                estudiantes = Convert.ToInt32(Console.ReadLine());
                calif[i] = new float[estudiantes];
            }
            for(int i=0;i<cursos;i++)//agregando calificaciones
            {
                for (int m=0; m<calif[i].GetLength(0);m++)
                {
                    Console.WriteLine("Calificacion {0} del curso {1}",(m+1),(i+1));
                    notas = Convert.ToSingle(Console.ReadLine());
                    calif[i][m] = notas;
                }
            }
            for (int i=0;i<cursos;i++)
            {
                for (int m=0;m<calif[i].GetLength(0);m++)
                {
                    if (calif[i][m]>maximo)
                    {
                        maximo = calif[i][m];
                    }
                }
            }
            Console.WriteLine("La mayor nota es: {0}",maximo);
        }
    }
}
