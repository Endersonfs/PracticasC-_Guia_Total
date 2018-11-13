using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable necesaria
            int indice = 0;
            int cantidad = 0;

            //instanciando ArrayList
            ArrayList datos = new ArrayList();
            //agregando valores
            datos.Add(7);
            datos.Add(5);
            datos.Add(1);
            //imprimiendo en consola el titulo
            Console.WriteLine("Tenemos inicial mente en consola: ");
            //imprimiendo datos
            Impriendo(datos);

            //hacemos crecer el arry
            datos.Add(4);
            datos.Add(5);
            //obtenemos el indice
            indice = datos.Add(10);
            //imprimiendo
            Console.WriteLine("Despues de hacerlo crecer");
            Impriendo(datos);
            //imprimiendo el ultimo indice
            Console.WriteLine("El ultimo elemento tiene el indice {0}", indice);
            //espacio
            Console.WriteLine("\n_________________");
            //imprimiendo un elemento en particular
            Console.WriteLine("El valor en el indice 2 es: {0} ", datos[2]);
            //modificamos un dato
            datos[3] = 55;
            //despues de la modificacion
            Console.WriteLine("Despues de la modificacion");
            Impriendo(datos);
            //obtemos la cantidad
            cantidad = datos.Count;
            Console.WriteLine("La cantidad de elementos es: {0}", cantidad);
            Console.WriteLine("\n_________________");
            //insertamos un elemento
            datos.Insert(2, 88);
            //despues de insertar elemento
            Console.WriteLine("Despues de la insercion");
            Impriendo(datos);
            //eliminando elemento
            datos.RemoveAt(4);
            Console.WriteLine("Despues de eliminar el elemento");
            Impriendo(datos);
            //encontrando el indice
            indice = datos.IndexOf(5);
            Console.WriteLine("El primero 5 encontrado esta en la posicion {0}",indice);
        }
        static void Impriendo(ArrayList arreglo)
        {
            foreach (int n in arreglo)
            {
                Console.Write("{0}, ",n);
            }
            Console.WriteLine("\n______________");
        }
    }
}
