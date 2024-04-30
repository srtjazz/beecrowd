using System;

//Fibonacci Fácil

//A seguinte sequência de números 0 1 1 2 3 5 8 13 21... é conhecida como série de Fibonacci. Nessa sequência, cada número,
//depois dos 2 primeiros, é igual à soma dos 2 anteriores. Escreva um algoritmo que leia um inteiro N (N < 46) e mostre
//os N primeiros números dessa série.

//Entrada
//O arquivo de entrada contém um valor inteiro N (0 < N < 46).

//Saída
//Os valores devem ser mostrados na mesma linha, separados por um espaço em branco. Não deve haver espaço após o último valor.

class URI
{

	static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		int next = 0;
		int previous = 0;
		int actual = 1;

		for (int i = 1; i <= n; i++)
		{
            if (i == n)
            {
                Console.WriteLine(previous);
            }
            else
            {
                Console.Write(previous + " ");
            }
			next = previous + actual;
			previous = actual;
			actual = next;
        }
	}

}