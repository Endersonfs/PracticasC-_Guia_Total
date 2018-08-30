using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            int numero;
            //capturando datos
            Console.WriteLine("1. Transformar grados a Radianes");
            Console.WriteLine("2. Transformar grados centígrados a grados Fahrenheit");
            Console.WriteLine("3. Transfomrar perímetro de polígono regular");
            Console.WriteLine("4. Calcular el factorial de un número.");
            Console.WriteLine("5. Transformar de Numero a Letras");
            numero = Convert.ToInt32(Console.ReadLine());
            //comparando
            if (numero == 1)
            {
                //grados a radianes
                GradosRadianes();
            }
            else if (numero == 2)
            {
                //grados centigrados a fahrenheit
                CentigradosFahrenheit();
            }
            else if (numero == 3)
            {
                //perimetro de pologono regular
                PerimetroPoligonoRegular();
            }
            else if (numero == 4)
            {
                //factorial de un numero
                Factorial();
            }
            else if (numero == 5)
            {
                //numero a letras
                NumeroLetra();
            }
            else
            {
                Console.WriteLine("Introdusca un valor que este en el intervalo");
            }

        }//final de metodo main
        static float PedirValor()
        {
            //variables necesaria
            float resultado = 0.0f;
            Console.WriteLine("Introdusca Su Valor: ");
            resultado = Convert.ToSingle(Console.ReadLine());
            return resultado;
        }//final de metodo pedir valor
        static void DarResultado(float valor)
        {
            Console.WriteLine("Su Resultado es: {0}", valor);
        }//final del metodo resultado
        static void GradosRadianes()
        {
            //variables necesarias
            float grados, resultado;
            grados = PedirValor();
            resultado = Convert.ToSingle((grados / 180) * 3.1416);
            DarResultado(resultado);
        }//final de la funcion grados a radianes
        static void CentigradosFahrenheit()
        {
            //variables necesarias
            float grado = 0.0f;
            float a, b, c, resultado;
            grado = PedirValor();
            //formulas para convertir
            a = grado * 2;
            b = a * 0.1f;
            c = a - b;
            resultado = c + 32;
            DarResultado(resultado);
        }//final de la funcion centigrados a fahrenheit
        static void PerimetroPoligonoRegular()
        {
            //variables necesarias
            float lados, Longitud, resultado;
            Console.WriteLine("Dame la cantidad de lados");
            lados = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Dame la cantidad de uno de sus lados");
            Longitud = Convert.ToSingle(Console.ReadLine());
            //formula
            resultado = lados * Longitud;
            DarResultado(resultado);
        }//final de la funcion perimeto 
        static void Factorial()
        {
            //varibles necesarias
            float numero;
            float resultado;
            float suma = 1f;
            //pedir valor
            numero = PedirValor();
            for (int i = 1; i <= numero; i++)
            {
                resultado = numero * Convert.ToSingle(i);
                suma *= i;
                Console.WriteLine("{0}x{1}={2}", numero, i, resultado);

            }
            Console.WriteLine("Su Factorial es: {0}", suma);
        }//final de la funcion factorial
        static void NumeroLetra()
        {
            //variables necesarias
            string a="";
            string resultado;
            a = Convert.ToString(PedirValor());
            String ab= Convert.ToString(a);
            if (ab.Length == 1)
            {
                resultado = Letras(a.Length);
                Console.WriteLine("Su resultado es, {0}, la cantidad de letras es: {1}", resultado, ab.Length);
            }
            else if (ab.Length == 2)
            {
                //variables necesarias
                string unidad = "";
                string decena = "";
                //calculo de tipo de variable
                unidad = Letras(Convert.ToSingle(a.Substring(0, 1) + 0));
                decena = Letras(Convert.ToSingle(a.Substring(1, 1)));
                Console.WriteLine("Su resultado es, {0} {1}", unidad, decena);
            }
            else if (ab.Length == 3)
            {
                //variables necesarias
                string unidad = "";
                string decena = "";
                string centena = "";
                //calculo de tipo de variable
                unidad = Letras(Convert.ToSingle(a.Substring(0, 1) + 0 + 0));
                decena = Letras(Convert.ToSingle(a.Substring(1, 1) + 0));
                centena = Letras(Convert.ToSingle(a.Substring(2, 1)));
                Console.WriteLine("Su resulado es, {0} {1} {2}", unidad, decena, centena);
            }
            else
            {
                Console.WriteLine("Solo puedo Leer los numeros hasta 999");
            }
        }//numeros letras
        static string Letras(float valor)
        {
            string resultado="";
            switch (valor)
            {
                case 1:
                    resultado = "Uno";
                    break;
                case 2:
                    resultado = "Dos";
                    break;
                case 3:
                    resultado = "Tres";
                    break;
                case 4:
                    resultado = "Cuatro";
                    break;
                case 5:
                    resultado = "Cinco";
                    break;
                case 6:
                    resultado = "Seis";
                    break;
                case 7:
                    resultado = "Siete";
                    break;
                case 8:
                    resultado = "Ocho";
                    break;
                case 9:
                    resultado = "Nueve";
                    break;
                case 10:
                    resultado = "Diez";
                    break;
                case 20:
                    resultado = "Veinte";
                    break;
                case 30:
                    resultado = "Treinta";
                    break;
                case 40:
                    resultado = "Cuarenta";
                    break;
                case 50:
                    resultado = "Cincuenta";
                    break;
                case 60:
                    resultado = "Sesenta";
                    break;
                case 70:
                    resultado = "Setenta";
                    break;
                case 80:
                    resultado = "Ochenta";
                    break;
                case 90:
                    resultado = "Noventa";
                    break;
                case 100:
                    resultado = "Cien";
                    break;
                case 200:
                    resultado = "Doscientos";
                    break;
                case 300:
                    resultado = "Tresciento";
                    break;
                case 400:
                    resultado = "Cuatrocien";
                    break;
                case 500:
                    resultado = "Quientos";
                    break;
                case 600:
                    resultado = "Seisciento";
                    break;
                case 700:
                    resultado = "Setecientos";
                    break;
                case 800:
                    resultado = "Ochocientos";
                    break;
                case 900:
                    resultado = "Noveciento";
                    break;
                case 1000:
                    resultado = "Mil";
                    break;

            }
            return resultado;
        }
    }
}
