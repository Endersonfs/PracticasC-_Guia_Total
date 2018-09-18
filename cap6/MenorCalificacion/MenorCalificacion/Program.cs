using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenorCalificacion
{
    class Program
    {
        //programa para calcular el menor numero de calificacion utilizando jagged
        static void Main(string[] args)
        {
            //variables necesarias
            int cursos = 0;
            int alumnos = 0;
            int notas = 0;
            float menor = 100.0f;
            //capturando datos
            Console.WriteLine("Dame la cantidad de Cursos");
            cursos = Convert.ToInt32(Console.ReadLine());
            //creando arreglo de jagged
            float[][] calif = new float[cursos][];

            for (int i=0;i<cursos;i++)//almacenando estudiantes
            {
                Console.WriteLine("Dame la cantidad de Estudiantes del curso #{0}",(i+1));
                alumnos = Convert.ToInt32(Console.ReadLine());
                calif[i] = new float [alumnos];
            }
            for (int i=0;i<cursos;i++)
            {
                for (int m=0;m< calif[i].GetLength(0);m++)
                {
                    Console.WriteLine("Dame la nota de estudiante #{0} del curso {1}",(m+1),(i+1));
                    notas = Convert.ToInt32(Console.ReadLine());
                    calif[i][m] = notas;  
                }
            }
            for (int i=0; i<cursos;i++)
            {
                for (int m=0;m<calif[i].GetLength(0);m++)
                {
                    if (calif[i][m] < menor)
                    {
                        menor = calif[i][m];
                    }
                }                
            }
            for (int i=0;i<cursos;i++)//imprimiendo resultado
            {
                for (int m=0;m<cursos;m++)
                {
                    Console.WriteLine(calif[i][m]);
                }
                
            }
            Console.WriteLine("El menor numero es: {0}",menor);

        }
    }
}
