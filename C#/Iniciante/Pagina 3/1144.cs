using System;

//Sequ�ncia L�gica

//Escreva um programa que leia um valor inteiro N. N * 2 linhas de sa�da ser�o apresentadas na execu��o do programa,
//seguindo a l�gica do exemplo abaixo. Para valores com mais de 6 d�gitos, todos os d�gitos devem ser apresentados.

//Entrada
//O arquivo de entrada cont�m um n�mero inteiro positivo N (1 < N < 1000).

//Sa�da
//Imprima a sa�da conforme o exemplo fornecido.

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int totalLines = n * 2;
        int counter = 0;

        for (int i = 1; counter < totalLines;)
        {
            Console.WriteLine($"{i} {i * i} {i * i * i}");
            Console.WriteLine($"{i} {(i * i) + 1} {(i * i * i) + 1}");
            i++;
            counter+=2;
        }
    }

}