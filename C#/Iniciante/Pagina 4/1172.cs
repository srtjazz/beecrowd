using System;
using System.Collections.Generic;
using System.Diagnostics;

//Substituição em Vetor I

//Faça um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos do vetor X por 1.
//Em seguida mostre o vetor X.

//Entrada
//A entrada contém 10 valores inteiros, podendo ser positivos ou negativos.

//Saída
//Para cada posição do vetor, escreva "X[i] = x", onde i é a posição do vetor e x é o valor armazenado naquela posição.
//Faça um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos do vetor X por 1.
//Em seguida mostre o vetor X.

//Entrada
//A entrada contém 10 valores inteiros, podendo ser positivos ou negativos.

//Saída
//Para cada posição do vetor, escreva "X[i] = x", onde i é a posição do vetor e x é o valor armazenado naquela posição.

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