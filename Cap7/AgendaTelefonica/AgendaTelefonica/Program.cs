using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necestarias
            int valor = 0;
            string valorBuscar = "";
            //instancia de los datos
            Hashtable misDatos = new Hashtable();

            do
            {
                Console.WriteLine("------ Menu pricipal ------\n");
                Console.WriteLine("1- Agregar numero");
                Console.WriteLine("2- Buscar Numero");
                Console.WriteLine("3- Salir");
                valor = Convert.ToInt32(Console.ReadLine());

                //condiciones
                if (valor == 1)
                {//agregando contacto
                 //variables necesarias
                    Console.Clear();
                    string nombre = "";
                    long numero = 0;
                    Console.WriteLine("Nombre de contacto");
                    nombre = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Numero telefonico");
                    numero = Convert.ToInt64(Console.ReadLine());
                    misDatos.Add(nombre, numero);
                    Console.Clear();
                }
                if (valor == 2)
                {//bucando contacto
                    Console.Clear();
                    Console.WriteLine("Dame el nombre a buscar");
                    valorBuscar = Convert.ToString(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("El numero encontrado {0}", misDatos[valorBuscar]);
                }
           
            } while (valor != 3);
        }//metodo main
    }
}
