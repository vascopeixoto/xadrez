using System;
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMov { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            qteMov = 0;
        }

    }
}
