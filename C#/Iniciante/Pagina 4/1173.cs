using System;

//Preenchimento de Vetor I

//Leia um valor e fa�a um programa que coloque o valor lido na primeira posi��o de um vetor N[10]. Em cada posi��o
//subsequente, coloque o dobro do valor da posi��o anterior. Por exemplo, se o valor lido for 1, os valores do
//vetor devem ser 1,2,4,8 e assim sucessivamente. Mostre o vetor em seguida.

//Entrada
//A entrada cont�m um valor inteiro (V<=50).

//Sa�da
//Para cada posi��o do vetor, escreva "N[i] = X", onde i � a posi��o do vetor e X � o valor armazenado na posi��o i.
//O primeiro n�mero do vetor N (N[0]) ir� receber o valor de V.Leia um valor e fa�a um programa que coloque o valor
//lido na primeira posi��o de um vetor N[10]. Em cada posi��o subsequente, coloque o dobro do valor da posi��o anterior.
//Por exemplo, se o valor lido for 1, os valores do vetor devem ser 1,2,4,8 e assim sucessivamente. Mostre o vetor em seguida.

//Entrada
//A entrada cont�m um valor inteiro (V<=50).

//Sa�da
//Para cada posi��o do vetor, escreva "N[i] = X", onde i � a posi��o do vetor e X � o valor armazenado na posi��o i.
//O primeiro n�mero do vetor N (N[0]) ir� receber o valor de V.

class URI
{

    static void Main(string[] args)
    {
        int[] N = new int[10];
        N[0] = int.Parse(Console.ReadLine());
        
        for (int i = 1; i < N.Length; i++)
        {
            N[i] = N[i - 1] * 2;
        }

        for (int i = 0; i < N.Length; i++)
        {
            Console.WriteLine($"N[{i}] = {N[i]}");
        }
    }

}