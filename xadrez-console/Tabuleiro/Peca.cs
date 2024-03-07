﻿
namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao {  get; set; }
        public Cor cor { get; protected set; }

        public int qteMovimento { get; protected set; }

        public Tabuleiro tab {  get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimento = 0;    
        }

        public abstract bool[,] movimentosPossiveis();
        

        public void incrementarQteMovimentos()
        {
            qteMovimento++;
        }
        
    }
}
