using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* FUNÇÃO DE EXECUÇÃO COM PARÂMETROS
               Utilizam parâmetros (entre parênteses) para executar um comando. */
            Console.WriteLine("Insira alguma coisa: ");

            /* FUNÇÃO DE RETORNO DE VALOR
               Coleta informações e guarda no sistema. */
            string algumacoisa = Console.ReadLine();

            /* FUNÇÃO DE EXECUÇÃO
               Fica sozinha na linha */
            Console.ReadKey();
        }
    }
}
