using System;

//N�meros �mpares

//Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os �mpares de 1 at� X, um valor por linha,
//inclusive o X, se for o caso.

//Entrada
//O arquivo de entrada cont�m 1 valor inteiro qualquer.

//Sa�da
//Imprima todos os valores �mpares de 1 at� X, inclusive X, se for o caso.

class URI
{

    static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"{i}");
            }
        }


    }

}