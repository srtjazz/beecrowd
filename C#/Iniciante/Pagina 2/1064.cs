using System;
using System.Runtime.InteropServices;

//Positivos e Média
//Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha,
//deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

//Entrada
//A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números
//será positivo.

//Saída
//O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores
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