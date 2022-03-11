using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Partida partida = new Partida();


                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicao().toPosicao();

                    bool[,] posicoespossiveis = partida.tab.peca(origem).movPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab,posicoespossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicao().toPosicao();

                    partida.executaMovimento(origem, destino);
                }



            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
