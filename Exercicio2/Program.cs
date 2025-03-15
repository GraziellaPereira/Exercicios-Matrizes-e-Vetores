using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome e preço de 10 produtos (em cada linha deve vir o produto junto de seu preço): ");
            string[] entrada = new string[2];
            string[] produto = new string[10];
            double[] preco = new double[10];

            for (int i = 0; i < 10; i++)
            {
                entrada = Console.ReadLine().Split( );
                produto[i] = entrada[0];
                preco[i] = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Agora digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Produtos: ");
            bool encontrou = false;
            for (int i = 0; i < 10; i++)
            {
                if (preco[i] <= valor)
                {
                    Console.WriteLine($"{produto[i]}");
                    encontrou = true;
                }
                
            }
            if (!encontrou)
            {
                Console.WriteLine("Nenhum produto encontrado com preço igual ou menor ao valor digitado.");
            }
            Console.ReadKey();

        }
    }
}
