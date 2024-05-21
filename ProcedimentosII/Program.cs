using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedimentosII
{
    internal class Program
    {
        static void quadrado()
        {
            Console.Write("Insira o valor do lado do quadrado: ");
            double x = double.Parse(Console.ReadLine());
            double a = x * x;
            Console.Write("Área: " + a);
        }

        static void retangulo()
        {
            Console.Write("Insira o valor da base do retângulo: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor da altura do retângulo: ");
            double y = double.Parse(Console.ReadLine());
            double a = x * y;
            Console.Write("Área: " + a);
        }

        static void losango()
        {
            Console.Write("Insira o valor da diagonal do losango: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor da outra diagonal do losango: ");
            double y = double.Parse(Console.ReadLine());
            double a = (x * y) / 2;
            Console.Write("Área: " + a);
        }

        static void trapezio()
        {
            Console.Write("Insira o valor da base do trapézio: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor da outra base do trapézio: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor da altura do trapézio: ");
            double z = double.Parse(Console.ReadLine());
            double a = ( (x + y) * z) / 2;
            Console.Write("Área: " + a);
        }

        static void Main(string[] args)
        {
            Console.Write("ESSCOLHA A FORMA GEOMÉTRICA\nQ - Quadrado . R - Retângulo . L - Losango . T - Trapézio : ");
            string f = Console.ReadLine();
            string forma = f.Substring(0, 1).ToUpper();
            switch (forma)
            {
                case "Q":
                    quadrado();
                    break;
                case "R":
                    retangulo();
                    break;
                case "L":
                    losango();
                    break;
                case "T":
                    trapezio();
                    break;
                default: 
                    Console.WriteLine("CÓDIGO INVÁLIDO!!"); 
                    break;
            }
            Console.ReadKey();
        }
    }
}
