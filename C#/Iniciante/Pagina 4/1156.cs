using System;

//Sequ�ncia S II

//Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela f�rmula:
//S = 1 + 3 / 2 + 5 / 4 + 7 / 8 + ... +39 /?

//Entrada
//N�o h� nenhuma entrada neste problema.

//Sa�da
//A sa�da cont�m um valor correspondente ao valor de S.
//O valor deve ser impresso com dois d�gitos ap�s o ponto decimal.

class URI
{

	static void Main(string[] args)
	{
		float s = 1;
		float j = 3;

		for (float i = 2; j <= 39; j += 2, i *= 2)
        {
			s += j / i;
		}

		Console.WriteLine($"{s:F2}");
	}

}