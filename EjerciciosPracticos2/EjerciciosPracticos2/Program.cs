using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos2
{
    class Program
    {
        static void Main(string[] args)
         {

            Console.WriteLine("Elige el programa que desea abrir:");
            Console.WriteLine("1)Calculadora de perimetros");
            Console.WriteLine("2)Conversor de grados a radianes");
            Console.WriteLine("3) De grados centigrados a fahrenheit");
            Console.WriteLine("4) Conversion entre euro y dolar");

            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    //Calcular cualquier poligono regular
                    int nlado;
                    int vlado;
                    Console.WriteLine("Ingrese numero de lado");
                    string a = Console.ReadLine();
                    Console.WriteLine("Ingrese valor de algun lado:");
                    string b = Console.ReadLine();
                    nlado = Convert.ToInt32(a);
                    vlado = Convert.ToInt32(b);
                    int perimetro = vlado * nlado;
                    Console.WriteLine("El perimetro es {0}", perimetro);
                    Console.ReadKey();
                    break;
                case 2:
                    //Calculadora de grados a radianes
                    Console.WriteLine("Ingrese un angulo");
                    double angulo = Convert.ToDouble(Console.ReadLine());
                    double radiante = angulo * Math.PI / 180;
                    Console.WriteLine("El resultado del angulo a radiane es {0} ", radiante);
                    Console.ReadKey();
                    break;
                case 3:
                    //De grados centigrados a fahrenheit
                    Console.Write("Ingrese un grado centigrado: ");
                    double gradoc = Convert.ToInt32(Console.ReadLine());
                    double fahrenheit = 1.8 * gradoc + 32;
                    Console.WriteLine("El resultado es {0}", fahrenheit);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Elija un valor a cambiar: 1:Euro, 2:Dolar");
                    int op = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese cambio del dia");
                    double cambio = Convert.ToDouble(Console.ReadLine());

                    if (op == 1)
                    {
                        double dolar = 1;
                    }
                    else
                    {

                    }
                    break;
            }
           

            

        }
    }
}
