using System;
using System.Collections.Generic;

//M�ltiplos de 13

//Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos n�meros que n�o s�o m�ltiplos de 13 entre X e Y,
//incluindo ambos.

//Entrada
//O arquivo de entrada cont�m 2 valores inteiros quaisquer, n�o necessariamente em ordem crescente.

//Sa�da
//Imprima a soma de todos os valores n�o divis�veis por 13 entre os dois valores lidos na entrada, inclusive ambos se
//for o caso.

class URI
{

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int totalValue = 0;

        if (x > y)
        {
            for (int i = y; i <= x; i++)
            {
                if (i % 13 != 0)
                {
                    totalValue += i;
                }
            }
        }
        else
        {
            for (int i = x; i <= y; i++)
            {
                if (i % 13 != 0)
                {
                    totalValue += i;
                }
            }
        }

        Console.WriteLine(totalValue);

    }

}