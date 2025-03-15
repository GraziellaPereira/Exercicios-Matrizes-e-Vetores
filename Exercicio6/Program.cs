using System;

namespace JogoDaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[3, 3];
            string jogadorO = "O";
            string jogadorX = "X";
            string jogadorAtual = jogadorX;
            int linha, coluna;
            bool fimDeJogo = false;
            int jogadas = 0; 

            // Inicialização do tabuleiro
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    tabuleiro[i, j] = " ";
            }
                
            // Enquanto o jogo não terminar, faz o loop
            while (!fimDeJogo)
            {
                Console.Clear(); // Limpeza do console no começo da rodada
                ImprimirTabuleiro(tabuleiro); 

                Console.WriteLine("\nJogador atual: " + jogadorAtual);
                Console.WriteLine("Digite a linha (1-3): ");
                linha = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Digite a coluna (1-3): ");
                coluna = Convert.ToInt32(Console.ReadLine()) - 1;

                // Se a posição estiver vazia, marca no tabuleiro, atribuindo ao jogador atual, O ou X e faz as verificações abaixo
                if (tabuleiro[linha, coluna] == " ")
                {
                    tabuleiro[linha, coluna] = jogadorAtual;
                    jogadas++; 

                    // Verifica se houve vitória associada ao jogador
                    if (VerificarVitoria(tabuleiro, jogadorAtual))
                    {
                        Console.Clear();
                        ImprimirTabuleiro(tabuleiro);
                        Console.WriteLine($"\nParabéns! O jogador {jogadorAtual} venceu!");
                        fimDeJogo = true;
                        break;
                    }
                    // Todo o tabuleiro foi preenchido, gerando empate
                    if (jogadas == 9)
                    {
                        Console.Clear();
                        ImprimirTabuleiro(tabuleiro);
                        Console.WriteLine("\nDeu velha! O jogo terminou em empate.");
                        fimDeJogo = true;
                        break;
                    }

                    // Se o jogador atual for x, muda pra o e vice-versa
                    jogadorAtual = (jogadorAtual == jogadorX) ? jogadorO : jogadorX;
                }
                else
                {
                    Console.WriteLine("Posição ocupada! Escolha outra.");
                    Console.ReadKey(); 
                }
            }

            Console.ReadKey();
        }
        // Método de montagem do tabuleiro
        static void ImprimirTabuleiro(string[,] tabuleiro)
        {
            Console.WriteLine("  1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {tabuleiro[i, j]} ");
                    if (j < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("  ---+---+---");
            }
        }
        // Método para verificar vitória
        static bool VerificarVitoria(string[,] tabuleiro, string jogador)
        {

            for (int i = 0; i < 3; i++)
            {
                if ((tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador) ||
                    (tabuleiro[0, i] == jogador && tabuleiro[1, i] == jogador && tabuleiro[2, i] == jogador))
                    return true;
            }


            if ((tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador) ||
                (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador))
                return true;

            return false;
        }
    }
}
