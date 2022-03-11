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

        public void decrementar()
        {
            qteMov--;
        }

        public bool existemMovPoss()
        {
            bool[,] mat = movPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movPossiveis();
    }
}
