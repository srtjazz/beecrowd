using System;

//Sequencia IJ 4

//Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

//Entrada
//Não há nenhuma entrada neste problema.

//Saída
//Imprima a sequencia conforme exemplo abaixo.

//Exemplo de Entrada	Exemplo de Saída
//                      I=0 J=1
//                      I=0 J=2
//                      I=0 J=3
//                      I=0.2 J=1.2
//                      I=0.2 J=2.2
//                      I=0.2 J=3.2
//                      .....
//                      I=2 J=?
//                      I=2 J=?
//                      I=2 J=?

class URI
{

    static void Main(string[] args)
    {
        double i = 0;
        double j = 1;

        while (i < 2)
        {
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"I={i} J={j}");
                j++;
            }
            i += 0.2;
            j -= 2.8;
        }
    }

}