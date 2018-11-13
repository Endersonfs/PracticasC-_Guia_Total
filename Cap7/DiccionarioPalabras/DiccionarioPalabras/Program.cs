using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DiccionarioPalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias 
            int valor = 0;
            //instanciando  hastable
            Hashtable datos = new Hashtable();
            do
            {
                Console.Title = "Diccionario";
                Console.WriteLine("----------- Menu Principal ----------- \n");
                Console.WriteLine("1- Nueva palabra");
                Console.WriteLine("2- Buscar Palabra");
                Console.WriteLine("3- Salir");
                valor = Convert.ToInt32(Console.ReadLine());
                //seleccionando  el valor
                if (valor == 1)
                {
                    Console.Clear();
                    string Nombre = "";
                    string Definicion = "";
                    Console.WriteLine("Nombre de palabra");
                    Nombre = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Definicion");
                    Definicion = Convert.ToString(Console.ReadLine());
                    datos.Add(Nombre,Definicion);
                    Console.Clear();
                }
                if (valor == 2)
                {
                    string palabra="";
                    Console.WriteLine("Nombre de palabra");
                    palabra = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("{0}",datos[palabra]);
                }
                
            } while (valor != 3);
        }//metodo mein
        public static void buscar( Hashtable bus)
        {
            foreach (int n in bus)
            {
                Console.WriteLine("{0}",n);
            }
        }//metodo buscar
    }
}
