using System;

//Fibonacci F�cil

//A seguinte sequ�ncia de n�meros 0 1 1 2 3 5 8 13 21... � conhecida como s�rie de Fibonacci. Nessa sequ�ncia, cada n�mero,
//depois dos 2 primeiros, � igual � soma dos 2 anteriores. Escreva um algoritmo que leia um inteiro N (N < 46) e mostre
//os N primeiros n�meros dessa s�rie.

//Entrada
//O arquivo de entrada cont�m um valor inteiro N (0 < N < 46).

//Sa�da
//Os valores devem ser mostrados na mesma linha, separados por um espa�o em branco. N�o deve haver espa�o ap�s o �ltimo valor.

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