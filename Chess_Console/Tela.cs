using board;

namespace Chess_Console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int I = 0; I < tab.linhas; I++)
            {
                for (int J = 0; J < tab.colunas; J++)
                {
                    if(tab.peca(I, J) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(I, J) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
