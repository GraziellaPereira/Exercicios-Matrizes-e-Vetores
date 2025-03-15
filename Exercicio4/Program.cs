using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            int valor = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = valor++;
                }
            }
            Console.WriteLine("Valores das diagonais da matriz 5x5 de 1 a 25:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || i + j == 4) 
                    {
                        Console.Write($"{matriz[i, j],3} ");
                    }
                    else
                    {
                        Console.Write("    "); 
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
