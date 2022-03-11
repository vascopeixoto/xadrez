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
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);


                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicao().toPosicao();
                        partida.validarPosOrigem(origem);

                        bool[,] posicoespossiveis = partida.tab.peca(origem).movPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoespossiveis);

                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicao().toPosicao();
                        partida.validarPosDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
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
