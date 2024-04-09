using System;
using System.Collections.Generic;
using System.Linq;

//Maior e Posi��o

//Leia 100 valores inteiros. Apresente ent�o o maior valor lido e a posi��o dentre os 100 valores lidos.

//Entrada
//O arquivo de entrada cont�m 100 n�meros inteiros, positivos e distintos.

//Sa�da
//Apresente o maior valor lido e a posi��o de entrada, conforme exemplo abaixo.

class URI
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            int typedNumber = int.Parse(Console.ReadLine());
            list.Add(typedNumber);
        }

        int maxValue = list.Max();
        int maxValueIndex = list.IndexOf(maxValue);

        Console.WriteLine($"{maxValue}\n" +
            $"{maxValueIndex + 1}");
    }

}