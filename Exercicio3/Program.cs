using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas = 0, colunas = 0;
            Console.WriteLine("Escolha o formato da matriz:");
            Console.WriteLine("1 - Matriz 3x5");
            Console.WriteLine("2 - Matriz 5x3");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    linhas = 3;
                    colunas = 5;
                    break;

                case 2:
                    linhas = 5;
                    colunas = 3;
                    break;

                default:
                    Console.WriteLine("Opção inválida! Digite 1 ou 2.");
                    return;
            }
            int[,] matriz = new int[linhas, colunas];
            Console.WriteLine("Agora digite os números no formato da matriz escolhida, linha por linha: ");
            for (int i = 0; i < linhas; i++)
            {
                string[] entrada = Console.ReadLine().Split();
                
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = int.Parse(entrada[j]);
                }
            }
            Console.WriteLine("Soma dos valores de cada linha: ");
            for (int i = 0; i < linhas; i++)
            {
                int soma = 0;
                for (int j = 0; j < colunas; j++)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine($"Linha {i + 1}: {soma}");
            }
            Console.ReadKey();
        }
    }
}
