using System;

//Resto 2

//Leia um valor inteiro N. Apresente todos os n�meros entre 1 e 10000 que divididos por N d�o resto igual a 2.

//Entrada
//A entrada cont�m um valor inteiro N (N < 10000).

//Sa�da
//Imprima todos valores que quando divididos por N d�o resto = 2, um por linha.

class URI
{

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i < 10000; i++)
        {
            if (i % number == 2)
            {
                Console.WriteLine($"{i}");
            }
        }
    }

}