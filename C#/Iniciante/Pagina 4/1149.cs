using System;
using System.Globalization;

//Somando Inteiros Consecutivos

//Fa�a um algoritmo para ler um valor A e um valor N. Imprimir a soma de A + i para cada i com os valores (0 <= i <= N-1).
//Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.

//Entrada
//A entrada cont�m somente valores inteiros, podendo ser positivos ou negativos. Todos os valores est�o na mesma linha.

//Sa�da
//A sa�da cont�m apenas um valor inteiro.

class URI
{

	static void Main(string[] args)
	{
		string[] values = Console.ReadLine().Split(' ');
		int a = int.Parse(values[0]);
		int n = int.Parse(values[1]);
		while (n <= 0)
		{
			n = int.Parse(Console.ReadLine());
		}
		int sum = 0;
		for (int i = 0; i < n; i++)
		{
			sum += a + i;
		}
		Console.WriteLine(sum);

	}

}