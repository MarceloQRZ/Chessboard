﻿using System;
using board;
using xadrez;

namespace Chess_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(Cor.Azul, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Azul, tab), new Posicao(1, 3));
            tab.colocarPeca(new Rei(Cor.Azul, tab), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab); 
            Console.ReadLine(); 
        }
    }
}