using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int numero = 0;
            //capturando datos
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicion");
            Console.WriteLine("4. Division");
            Console.Write("Escribe la opcion que desea: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 1)
            {
                //suma
                suma();
            }
            else if (numero == 2)
            {
                //variable para resultado
                float resultado = 0;
                //asignando valor de funcion a la variable
                resultado=resta();
                //imprimiendo el valor
                Console.WriteLine("El resultado es: {0}",resultado);
            }
            else if (numero == 3)
            {
                //multiplicacion
                //variables necesarias
                float a = 0;
                float b = 0;
                /* 
                string Numero = "";
                //capturando datos
                Console.WriteLine("Dame el primer dato");
                Numero = Console.ReadLine();
                a = Convert.ToSingle(Numero);
                /*Console.WriteLine("Dame el segundo dato");
                Numero = Console.ReadLine();
                b = Convert.ToSingle(Numero);
                //imprimiendo resultado
                */

                //nueva forma utilizando optimizacion
                a = pideFlotante("Dame el primer numero");
                b = pideFlotante("Dame el segundo numero");
                multiplicar(a,b);
            }
            else if (numero == 4)
            {
                //division
                //variables necesarias
                float a = 0, b = 0;
                float resulstado;
                //Capturando datos
                //nueva forma optimizacion de datos
                a = pideFlotante("Dame el primer dato");
                b = pideFlotante("Dame el segundo dato");
                //invocamos a la funcion
                resulstado = division(a, b);
                //imprimeindo resultado
                Console.WriteLine("El Resultado es: {0}",resulstado);
            }
            else
            {
                //no es una opcion
                Console.WriteLine("Digite una Opcion Correcta");
            }//final del if
        }//final del metodo main
        static void suma()
        {
            //variables necesarias
            float a = 0, b = 0, r = 0;
            //pedimos los valores
            a = pideFlotante("Dame el primer dato");
            b = pideFlotante("Dame el segundo dato");

            //calculamos el resultado
            r = a + b;
            //imprimiendo resultado
            Console.WriteLine("El Resultado es: {0}", r);
        }//metodo suma
        static float resta()
        {
            //variables necesarias
            float a = 0, b = 0, r = 0;
            //pedimos los valores
            a = pideFlotante("Dame el primer dato");
            b = pideFlotante("Dame el segundo dato");
            //calculamos el resultado
            r = a - b;
            //retornamos el resultado
            return r;
        }//final del metodo resta
        static void multiplicar(float a,float b)
        {
            //variables necesarias
            float r = 0;
            //calculamos el resultado
            r = a * b;
            //mostramos el resultado
            Console.WriteLine("El resultado es: {0}",r);
        }//final del metodo multiplicar
        static float division(float a, float b)
        {
            //variables necesarias
            float r = 0;
            if (b == 0)
            {
                Console.WriteLine("No es Posible Dividir en 0 (Infinito)");
                return 0.0f;
            }
            else
            {
                r = a / b;
                return r;
            }
        }//final del metodo division
        static float pideFlotante(string mensaje)
        {
            //variables necesarios
            float numero = 0.0f;
            string valor = "";
            //mostramos el mensaje 
            Console.WriteLine(mensaje);
            //obtenemos el valor
            valor = Console.ReadLine();
            numero = Convert.ToSingle(valor);
            //regresamos el dato
            return numero;
        }
    }
}
