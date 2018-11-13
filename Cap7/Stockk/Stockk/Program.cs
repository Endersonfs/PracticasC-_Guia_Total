using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stockk
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;
            //creamos el stack o pila
            Stack datos = new Stack();
            
            do {
                //mostrando menu
                Console.WriteLine("----------------- Menu Principal -----------------");
                Console.WriteLine("1- Push");
                Console.WriteLine("2- Pop");
                Console.WriteLine("3- Clear");
                Console.WriteLine("4- Constain");
                Console.WriteLine("5- Mostrar todos los Datos");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Dame una Opcion");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                if (opcion== 1)
                {
                    
                    Console.Clear();//borrando datos de la pantalla
                    Console.WriteLine("Dame el dato que quieres introducir");
                    valor = Console.ReadLine();
                    datos.Push(valor);
                    //borrando datos
                    Console.Clear();                   

                }
                else if (opcion== 2)
                {
                    //mostrando ultimo valor
                    Console.Clear();
                    Console.WriteLine("El ultimo valor es: {0}", datos.Pop());
                }
                else if (opcion== 3)
                {
                    //eliminando todos los datos
                    Console.Clear();
                    Console.WriteLine("Se elimino todos los datos del Stack o Pila");
                    datos.Clear();
                }
                else if (opcion== 4)
                {
                    //Buscando datos especifico
                    Console.Clear();
                    Console.WriteLine("Dame el valor a buscar");
                    numero = Convert.ToInt32(Console.ReadLine());
                    encontrado = datos.Contains(numero);
                    
                    if (encontrado == true)
                    {
                        Console.WriteLine("Existe el valor numero {0} digitado", numero);
                    }
                    else
                    {
                        Console.WriteLine("No se encontro el valor {0}", numero);
                    }

                }
                else if (opcion==5)
                {
                    //mostrando todos los datos
                    Imprimir(datos);
                }
            } while (opcion !=6);

        }
        static void Imprimir(Stack colecion)
        {
            foreach (int n in colecion)
            {
                Console.WriteLine("{0}, ",n);
            }
        }
    }
}
