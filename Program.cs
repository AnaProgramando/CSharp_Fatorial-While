using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_FatorialWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double contador = 0;
            double fatorial = 1;

            Console.WriteLine("Executando Projeto - Fatorial com While: \r\n");

            while (contador <= 9)
            {
                contador++;
                fatorial = fatorial * contador;                
                Console.WriteLine("O fatorial de " + contador + " = " + fatorial);
            }
            Console.ReadLine();
        }
    }
}
