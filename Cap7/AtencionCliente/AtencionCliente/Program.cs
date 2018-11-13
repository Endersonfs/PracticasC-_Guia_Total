using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AtencionCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            int valor = 0;
            string cliente = "";
            //instanciando los datos
            Queue datos = new Queue();
            do
            {
                Console.Title = "Atencion al Cliente";
                Console.WriteLine("---------- Menu ----------");
                Console.WriteLine("1- Nuevo Cliente");
                Console.WriteLine("2- Atender CLiente");
                Console.WriteLine("3- Salir");
                //capturando valor
                valor = Convert.ToInt32(Console.ReadLine());

                if ( valor == 1)
                {
                    Console.Clear();
                    Console.Title = "Agregando Cliente";
                    Console.WriteLine("Dame el nombre del cliente");
                    cliente = Convert.ToString(Console.ReadLine());
                    datos.Enqueue(cliente);
                    Console.Clear();

                }
                if (valor == 2)
                {
                    Console.Clear();
                    Console.Title = "Atender Cliente";
                    Console.WriteLine("Cliente para atender: {0}",datos.Dequeue());
                }
            } while (valor !=3);
        }
    }
}
