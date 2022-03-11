using System;
namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMov { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMov = 0;
        }

        public void incrementar()
        {
            qteMov++;
        }

        public abstract bool[,] movPossiveis();
    }
}
