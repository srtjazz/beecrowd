using System;

//Sequ�ncia S

//Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela f�rmula:
//S = 1 + 1 / 2 + 1 / 3 + � +1 / 100

//Entrada
//N�o h� nenhuma entrada neste problema.

//Sa�da
//A sa�da cont�m um valor correspondente ao valor de S.
//O valor deve ser impresso com dois d�gitos ap�s o ponto decimal.

class URI
{

    static void Main(string[] args)
    {
        double s = 1;

        for (int i = 2; i <= 100; i++)
        {
            s += 1.00 / i;
        }

        Console.WriteLine($"{s:F2}");

    }

}