using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Program
    {
        //programa de la escuela con funciones
        static void Main(string[] args)
        {
            //variables necesarias
            int curso = 0;
            int estudiantes = 0;
            float resultado = 0.0f;
            //capturando datos
            Console.WriteLine("Dame la cantidad de curso");
            curso = Convert.ToInt32(Console.ReadLine());
            //agregando arreglo jagged
            float[][] calif = new float[curso][];
            capturarEstudiantes(curso,estudiantes,calif);
            almacenar(curso,resultado,calif);
            imprimir(curso,calif);
            Console.WriteLine("Feliciades a todos los numero mayores de 70. :D");


        }        
        public static void capturarEstudiantes(int curso, int estudiantes,float[][]calif)
        {
            Console.WriteLine("--------------------------Cantidad de Estudiantes--------------------------");
            for (int i = 0; i < curso; i++)
            {
                Console.WriteLine("Dame la cantidad de estudiante del curso {0}", (i + 1));
                estudiantes = Convert.ToInt32(Console.ReadLine());
                calif[i] = new float[estudiantes];
            }
        }//final de la funcion capturarEstudiantes
        public static void almacenar(int curso, float resultado,float[][]calif)
        {
            Console.WriteLine("--------------------------Notas de Estudiantes--------------------------");
            for (int i=0;i<curso;i++)
            {
                for (int a=0;a<calif[i].GetLength(0);a++)
                {
                    Console.WriteLine("Dame la nota del estudiante {0} del curso{1}",(a+1),(i+1));
                    resultado = Convert.ToSingle(Console.ReadLine());
                    calif[i][a]=resultado;
                }
            }
        }//final del metodo almacenar
        public static void imprimir(int curso,float [][]calif)
        {
            Console.WriteLine("--------------------------Resultado--------------------------");
            for (int i = 0; i < curso; i++)
            {
                for (int b=0;b<calif[i].GetLength(0);b++)
                {
                    Console.WriteLine("La notas del estudiante {0} del curso {1} es: {2}",(b+1),(i+1),calif[i][b]);
                }
            }
        }
    }
}
