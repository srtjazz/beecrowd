using System;
using System.Collections.Generic;

//Idades

//Fa�a um algoritmo para ler um n�mero indeterminado de dados, contendo cada um, a idade de um indiv�duo. O �ltimo dado,
//que n�o entrar� nos c�lculos, cont�m o valor de idade negativa. Calcular e imprimir a idade m�dia deste grupo de indiv�duos.

//Entrada
//A entrada cont�m um n�mero indeterminado de inteiros. A entrada ser� encerrada quando um valor negativo for lido.

//Sa�da
//A sa�da cont�m um valor correspondente � m�dia de idade dos indiv�duos.

//A m�dia deve ser impressa com dois d�gitos ap�s o ponto decimal.

class URI
{

	static void Main(string[] args)
	{
		int n = 0;
		double sum = 0;
		List<int> numbers = new List<int>();

		while (n >= 0)
		{
			n = int.Parse(Console.ReadLine());
			if (n > 0)
			{
				sum += n;
				numbers.Add(n);
			}
		}
		double media = sum / numbers.Count;

		Console.WriteLine($"{media:F2}");
	}

}