using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necesaria 
            int indice = 0;
            int cantidad = 0;
            //declarammos el arrays
            ArrayList datos = new ArrayList();
            //adicionamos valores al array datos
            datos.Add(7);
            datos.Add(5);
            datos.Add(1);
            
            //imprimiendo enuncuiado
            Console.WriteLine("Tenemos Inicialmente los datos:");
            Imprime(datos);
            Console.WriteLine("\n--------------------------");
            //agregamos mas adiciones
            datos.Add(4);
            datos.Add(5);
            //obtenemos el indice
            indice = datos.Add(10);
            //despues de hacerlo crecer
            Console.WriteLine("Despues de hacerlo crecer: ");
            Imprime(datos);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("El utlimo elemento tiene el ultimo indece: {0}",indice);
            Console.WriteLine("\n--------------------------");

            //no quedamos por la pagina 228
        }
        public static void Imprime(ArrayList Arreglo)
        {
            foreach (int a in Arreglo)
            {
                Console.Write("{0}, ",a);
            }
        }

    }
}
