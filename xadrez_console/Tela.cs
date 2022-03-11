using System;
using tabuleiro;
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
                    if (tab.peca(i, j) == null)
                        Console.Write("- ");
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    -----------------");
            Console.WriteLine("      a b c d e f g h");
            Console.ForegroundColor = aux;
        }

        public static void imprimirPeca(Peca peca)
        {
            ConsoleColor aux = Console.ForegroundColor;

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
        }

    }
}
