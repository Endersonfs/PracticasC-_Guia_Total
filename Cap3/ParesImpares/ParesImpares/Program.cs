using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            float dato = 0.0f;
            //pidiendo datos
            Console.WriteLine("Digite el numero");
            //convirtiendo datos
            dato = Convert.ToSingle(Console.ReadLine());
            //verificacion de numero
            if (dato%2 ==0)
            {
                Console.WriteLine("Es un Numero entero");
            }
            else
            {
                Console.WriteLine("No es Numero entero");
            }
        }
    }
}
