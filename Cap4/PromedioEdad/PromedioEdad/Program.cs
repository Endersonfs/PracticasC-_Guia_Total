using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculando datos
            int[] a;
            a = new int[8];
            a[0] = 400;
            a[1] = 1;
            a[2] = 310;
            a[3] = 24;
            a[4] = 34;
            a[5] = 2;
            a[6] = 234;
            a[7]=43;
            //almacenando valores
            int resultado=0;

            for (int i=0;i<8;i++)//numeros de vuelta
            {
                resultado += a[i];
            }
            Console.WriteLine("El promedio de edad de todo el grupo es: {0}",resultado);
        }
    }
}
