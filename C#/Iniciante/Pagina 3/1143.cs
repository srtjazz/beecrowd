using System;

//Quadrado e ao Cubo

//Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N � a quantidade de linhas de sa�da que
//ser�o apresentadas na execu��o do programa.

//Entrada
//O arquivo de entrada cont�m um n�mero inteiro positivo N.

//Sa�da
//Imprima a sa�da conforme o exemplo fornecido.

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 1; counter < n; i++)
        {
            Console.WriteLine($"{i} {i*i} {i*i*i}");
            counter++;
        }

    }

}