using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDeLaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int dia=0;
            //entrada de datos
            Console.WriteLine("Introduce el numero del dia");
            //capturando datos
            dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
            }
            if (dia > 7 || dia < 1)
            {
                Console.WriteLine("El Valor Introducido no esta en el Intervalo de los Dias");
            }
        }
    }
}
