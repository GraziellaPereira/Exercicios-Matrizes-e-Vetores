using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite 15 valores inteiros: ");
            string[] vetor = Console.ReadLine().Split();
            int[] numeros = new int[15];

            for (int i = 0; i < 15; i++)
            {
                numeros[i] = int.Parse(vetor[i]);
            }

            Console.WriteLine("Números nas posições pares: ");
            for (int i = 0; i < 15; i+=2)
            {
                Console.WriteLine($"{numeros[i]}");
            }

            Console.ReadKey();
        }
    }
}
