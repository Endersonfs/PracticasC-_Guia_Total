using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dato = new ArrayList();
            dato.Add("Enderson");//agregando valores
            dato.Add("Erickson");
            dato.Add(5);
            dato.Add(true);

            int cantidad = dato.Count; //contando la cantidad
            //insertando valores 
            dato.Insert(4,"Nueva insercion");
            //eliminando espacio especifico
            dato.RemoveAt(2);
            //buscando elemento 
            dato.IndexOf("End");

            foreach (int a in dato)//recoriendo los datos
            {
                //imprimiendo los datos
                Console.WriteLine("Numero {0}");
            }
        }
    }
}
