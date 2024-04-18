using System;

//Resto da Divisão

//Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão
//dele por 5 for igual a 2 ou igual a 3.

//Entrada
//O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.

//Saída
//Imprima todos os valores conforme exemplo abaixo, sempre em ordem crescente.

class URI
{

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            for (int i = y + 1; i <= x; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else if (y > x)
        {
            for (int i = x + 1; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}