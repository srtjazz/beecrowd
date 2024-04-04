using System;
using System.Runtime.InteropServices;

//Positivos e M�dia
//Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na pr�xima linha,
//deve-se mostrar a m�dia de todos os valores positivos digitados, com um d�gito ap�s o ponto decimal.

//Entrada
//A entrada cont�m 6 n�meros que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes n�meros
//ser� positivo.

//Sa�da
//O primeiro valor de sa�da � a quantidade de valores positivos. A pr�xima linha deve mostrar a m�dia dos valores
//positivos digitados.

class URI
{

    static void Main(string[] args)
    {
        int quantity = 0;
        double numbersSum = 0;
        for (int i = 0; i < 6; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > 0)
            {
                quantity++;
                numbersSum += number;
            }

        }
        double media = numbersSum / quantity;
        Console.WriteLine($"{quantity} valores positivos");
        Console.WriteLine($"{media:F1}");

    }

}