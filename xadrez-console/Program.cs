﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Posicao p;

            p = new Posicao(3, 4);
            Console.WriteLine("Posição: " + p);

            Console.ReadKey();


        }
    }
}
