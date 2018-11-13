using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Calificaciones
{
    class Program
    {        
        static void Main(string[] args)
        {
            //variables necesarias
            int calificacion = 0;
            int valor = 0;
            //colecciones
            ArrayList datos = new ArrayList();
            //imprimiendo
            do
            {
                Console.WriteLine("Bienvenidos al sistema de calificacion");
                Console.WriteLine("1- Agregar Calificacion");
                Console.WriteLine("2- Mostrar Calificacion");
                Console.WriteLine("3- Calificacion Maxima");
                Console.WriteLine("4- Calificacion Minima");
                Console.WriteLine("5- Promedio de Calificacion");
                Console.WriteLine("6- Salir");
                //elegir opcion
                Console.WriteLine("Dame el Valor");
                valor = Convert.ToInt32(Console.ReadLine());

                if ( valor == 1)
                {//agregando calificacion
                    Console.Clear();
                    Console.Title = "Agregrando Calificacion";
                    Console.WriteLine("Digite La calificacion");
                    calificacion = Convert.ToInt32(Console.ReadLine());
                    datos.Add(calificacion);
                    Console.Clear();
                }
                if ( valor == 2)
                {//mostrando calificacion
                    Console.Clear();
                    Console.WriteLine("Lista de Calificaciones");
                    listaCalificacion(datos);
                }
                if ( valor == 3)
                {//maxima Calificacion
                    Console.Clear();
                    Console.Title = "Calificacion Maxima";
                    Console.WriteLine("Calificacion Maxima");
                    calificacionMaxima(datos);
                }
                if ( valor == 4)
                {
                    Console.Clear();
                    Console.Title = "Calificacion Minima";
                    Console.WriteLine("Calificacion Minima");
                    calificacionMinima(datos);
                }
                if ( valor == 5)
                {
                    Console.Clear();
                    Console.Title = "Calificacion Promedia";
                    Console.WriteLine("Calificacion Promedia");
                    promedio(datos);
                }
            } while (valor !=6);

        }
        public static void listaCalificacion(ArrayList lista)
        {
            foreach (int n in lista)
            {
                Console.Write("{0} ",n);
            }
            Console.WriteLine("\n______________");
        }//metodo lista de calificaciones
        public static void calificacionMaxima(ArrayList califMax)
        {
            int calif = 0;
            foreach (int n in califMax)
            {
                if (calif < n)
                {
                    calif = n;
                }
            }
            Console.WriteLine("La calificacion mayor es {0}",calif);
        }//metodo calificacion Maxima
        public static void calificacionMinima(ArrayList califm)
        {
            int calif = 0;
            foreach ( int n in califm)
            {
                if (calif == 0)
                {//agregando primer valor 
                    calif = n;
                }
                else if (calif > n)
                {
                    calif = n;
                }
            }
            Console.WriteLine("El numero menor es: {0}",calif);
        }//calificacion minima
        public static void promedio(ArrayList prome)
        {
            int promedio = 0;
            float resultado = 0;
            foreach (int n in prome)
            {
                promedio += n;
            }
            
            Console.WriteLine("El promedio es {0}", (resultado = promedio / prome.Count));
        }//final del metodo promedio
    }
}
