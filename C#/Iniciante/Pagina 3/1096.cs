using System;

//Sequencia IJ 2

//Voc� deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

//Entrada
//N�o h� nenhuma entrada neste problema.

//Sa�da
//Imprima a sequencia conforme exemplo abaixo

//Exemplo de Entrada	Exemplo de Sa�da
//                      I=1 J=7
//                      I=1 J=6
//                      I=1 J=5
//                      I=3 J=7
//                      I=3 J=6
//                      I=3 J=5
//                      ...
//                      I=9 J=7
//                      I=9 J=6
//                      I=9 J=5

class URI
{

    static void Main(string[] args)
    {
        int i = 1;
        while (i <= 9)
        {
            for (int j = 7; j > 4; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
            i += 2;
        }
    }

}