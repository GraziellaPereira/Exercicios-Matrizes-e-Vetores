using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome de 10 alunos junto com suas 3 notas (1 aluno por linha): ");
            string[] entrada = new string[10];
            string[] aluno = new string[10];
            double[,] notas = new double[10, 3];
            double[] medias = new double[10];
            for (int i = 0; i < 10; i++)
            {
               entrada = Console.ReadLine().Split();
               aluno[i] = entrada[0];
               double somaNotas = 0;
               for (int j = 0; j < 3; j++)
                {
                    notas[i, j] = double.Parse(entrada[j + 1], CultureInfo.InvariantCulture);
                    somaNotas += notas[i, j];
                }
                medias[i] = somaNotas / 3;
            }
            Console.WriteLine("\nRelatório de Notas:");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Nome\t\tNota 1\tNota 2\tNota 3\tMédia\tStatus");
            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                if (medias[i] >= 7.0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue; 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                }

         
                Console.WriteLine($"{aluno[i],-10}\t{notas[i, 0]:F2}\t{notas[i, 1]:F2}\t{notas[i, 2]:F2}\t{medias[i]:F2}\t{(medias[i] >= 7.0 ? "Aprovado" : "Reprovado")}");
            }

            Console.ResetColor(); 
            Console.WriteLine("-------------------------------------------------");

            Console.ReadKey();

        }
    }
}
