using System;
using System.Collections.Generic;

//Idades

//Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado,
//que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.

//Entrada
//A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.

//Saída
//A saída contém um valor correspondente à média de idade dos indivíduos.

//A média deve ser impressa com dois dígitos após o ponto decimal.

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