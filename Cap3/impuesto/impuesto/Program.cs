using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string nombreProducto;
            float precio;
            string tipoProducto= "null";
            float resultado;
            //captura de datos
            Console.WriteLine("Nombre del producto");
            nombreProducto = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Precio");
            precio = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Tipo de producto('producto medicial 0% de impuesto')");
            tipoProducto = Convert.ToString(Console.ReadLine());
            if (tipoProducto=="medicinal")
            {
                resultado = precio;
                Console.WriteLine("Su precio es, {0}",resultado);
            }
            else
            {
                resultado = (precio*0.029f);
                Console.WriteLine("Su impuesto es {0}",resultado);
            }
        }
    }
}
