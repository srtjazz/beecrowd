using System;

//Sequencia IJ 1

//Voc� deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

//Entrada
//N�o h� nenhuma entrada neste problema.

//Sa�da
//Imprima a sequencia conforme exemplo abaixo

//Exemplo de Entrada	Exemplo de Sa�da
//                      I=1 J=60
//                      I=4 J=55
//                      I=7 J=50
//                      ...
//                      I=? J=0

class URI
{

    static void Main(string[] args)
    {
        int j = 60;
        for (int i = 1; j >= 0;i+=3, j-=5)
        {
            Console.WriteLine($"I={i} J={j}");
        }
    }

}