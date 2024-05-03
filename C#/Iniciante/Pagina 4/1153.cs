using System;

//Fatorial Simples

//Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.

//Entrada
//A entrada cont�m um valor inteiro N (0 < N < 13).

//Sa�da
//A sa�da cont�m um valor inteiro, correspondente ao fatorial de N.

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i > 1;)
        {
            i--;
            n *= i;
        }

        Console.WriteLine(n);
    }

}