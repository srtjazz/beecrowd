using System;

//Sele�ao em Vetor I

//Fa�a um programa que leia um vetor A[100]. No final, mostre todas as posi��es do vetor que armazenam um valor menor
//ou igual a 10 e o valor armazenado em cada uma das posi��es.

//Entrada
//A entrada cont�m 100 valores, podendo ser inteiros, reais, positivos ou negativos.

//Sa�da
//Para cada valor do vetor menor ou igual a 10, escreva "A[i] = x", onde i � a posi��o do vetor e x � o valor armazenado
//na posi��o, com uma casa ap�s o ponto decimal.Fa�a um programa que leia um vetor A[100]. No final, mostre todas as
//posi��es do vetor que armazenam um valor menor ou igual a 10 e o valor armazenado em cada uma das posi��es.

//Entrada
//A entrada cont�m 100 valores, podendo ser inteiros, reais, positivos ou negativos.

//Sa�da
//Para cada valor do vetor menor ou igual a 10, escreva "A[i] = x", onde i � a posi��o do vetor e x � o valor armazenado
//na posi��o, com uma casa ap�s o ponto decimal.

class URI
{

    static void Main(string[] args)
    {
        double [] A = new double[100];

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = double.Parse(Console.ReadLine());

            if (A[i] <= 10)
            {
                Console.WriteLine($"A[{i}] = {A[i]:F1}");
            }
        }
    }

}