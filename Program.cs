﻿using System;
using xadrez;
using tabuleiro;

namespace Jogo_de_Xadrez___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
             {

                 Tabuleiro tab = new Tabuleiro(8, 8);

                 tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                 tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                 tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));

                 Tela.imprimirTabuleiro(tab);
             }
             catch (TabuleiroException e)
             {
                 Console.WriteLine(e.Message);
             }*/

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);


            Console.WriteLine(pos.toPosicao());
        }
    }
}
