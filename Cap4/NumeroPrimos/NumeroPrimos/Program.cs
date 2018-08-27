using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculando numero primeros
            
            for (int n=2;n<=1000;n++)//numero de vueltas
            {
                int a = 0;
            for (int i=1;i<=(n+1);i++)
            {
                if (n%i==0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                //Console.WriteLine("{0}, No es un numero Primo",n);
            }
            else
            {
                Console.WriteLine("{0}, Es un Numero primo",n);
            }
        }//segundo for
        }//primer for
    }
}
