using System;
using System.Collections.Generic;
using System.Diagnostics;

//Substitui��o em Vetor I

//Fa�a um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos do vetor X por 1.
//Em seguida mostre o vetor X.

//Entrada
//A entrada cont�m 10 valores inteiros, podendo ser positivos ou negativos.

//Sa�da
//Para cada posi��o do vetor, escreva "X[i] = x", onde i � a posi��o do vetor e x � o valor armazenado naquela posi��o.
//Fa�a um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos do vetor X por 1.
//Em seguida mostre o vetor X.

//Entrada
//A entrada cont�m 10 valores inteiros, podendo ser positivos ou negativos.

//Sa�da
//Para cada posi��o do vetor, escreva "X[i] = x", onde i � a posi��o do vetor e x � o valor armazenado naquela posi��o.

class URI
{

    static void Main(string[] args)
    {
        int[] X = new int[10];

        for (int i = 0; i < X.Length; i++)
        {
            X[i] = int.Parse(Console.ReadLine());

            if (X[i] <= 0)
            {
                X[i] = 1;
            }
            Console.WriteLine($"X[{i}] = {X[i]}");
        }
    }
}