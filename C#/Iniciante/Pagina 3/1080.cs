using System;
using System.Collections.Generic;
using System.Linq;

//Maior e Posição

//Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

//Entrada
//O arquivo de entrada contém 100 números inteiros, positivos e distintos.

//Saída
//Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

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