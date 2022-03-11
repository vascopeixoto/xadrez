using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            ConsoleColor aux = Console.ForegroundColor;

            for (int i = 0; i < tab.linhas; i++)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(8 - i + " " + " " + "|  ");
                Console.ForegroundColor = aux;
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    -----------------");
            Console.WriteLine("      a b c d e f g h");
            Console.ForegroundColor = aux;
        }

        public static void imprimirTabuleiro(Tabuleiro tab,bool[,] posicoesPossiveis)
        {
            ConsoleColor aux = Console.ForegroundColor;
            ConsoleColor fundo = Console.BackgroundColor;
            ConsoleColor fundo1 = ConsoleColor.Cyan;

            for (int i = 0; i < tab.linhas; i++)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(8 - i + " " + " " + "|  ");
                Console.ForegroundColor = aux;
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundo1;
                    }
                    else
                    {
                        Console.BackgroundColor = fundo;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundo;
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    -----------------");
            Console.WriteLine("      a b c d e f g h");
            Console.BackgroundColor = fundo;
            Console.ForegroundColor = aux;
        }

        public static PosicaoXadrez lerPosicao()
        {
            string s = Console.ReadLine();
            char linha = s[0];
            int coluna = int.Parse(s[1] + "");
            return new PosicaoXadrez(linha, coluna);
        }

        public static void imprimirPeca(Peca peca)
        {
            ConsoleColor aux = Console.ForegroundColor;

            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branco)
                {
                    Console.Write(peca);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

    }
}
