using System;

//Sequ�ncia L�gica 2

//Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequ�ncia de 1 at� Y, passando para a
//pr�xima linha a cada X n�meros.

//Entrada
//O arquivo de entrada cont�m dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

//Sa�da
//Cada sequ�ncia deve ser impressa em uma linha apenas, com 1 espa�o em branco entre cada n�mero, conforme
//exemplo abaixo. N�o deve haver espa�o em branco ap�s o �ltimo valor da linha.

class URI
{

    static void Main(string[] args)
    {
        string[] values = Console.ReadLine().Split(' ');
        int x = int.Parse(values[0]);
        int y = int.Parse(values[1]);

        for (int i = 1; i <= y; i++)
        {
            Console.Write($"{i}");
            if (i % x == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
    }

}