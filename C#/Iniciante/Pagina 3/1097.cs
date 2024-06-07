using System;

//Sequencia IJ 3

//Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

//Entrada
//Não há nenhuma entrada neste problema.

//Saída
//Imprima a sequencia conforme exemplo abaixo.

//Exemplo de Entrada	Exemplo de Saída
//                      I=1 J=7
//                      I=1 J=6
//                      I=1 J=5
//                      I=3 J=9
//                      I=3 J=8
//                      I=3 J=7
//                      ...
//                      I=9 J=15
//                      I=9 J=14
//                      I=9 J=13

class URI
{

    static void Main(string[] args)
    {
        int i = 1;
        int j = 7;
        while (i <= 9)
        {
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
            }
            i += 2;
            j += 5;
        }
    }

}