﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                 Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 9));

                Tela.imprimirTabuleiro(tab);
                 */

                PosicaoXadrez pos = new PosicaoXadrez('a', 1);

                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());
            }


            catch (TabuleiroException e)
            {
                
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
