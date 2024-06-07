using System;

//Sequência Lógica 2

//Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a
//próxima linha a cada X números.

//Entrada
//O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

//Saída
//Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, conforme
//exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.

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