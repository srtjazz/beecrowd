using System;

//Sequência de Números e Soma

//Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero).
//Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

//Entrada
//O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.

//Saída
//Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.

class URI
{

    static void Main(string[] args)
    {
        int totalValue = 0;
        bool counter = true;

        while (counter)
        {
            string[] values = Console.ReadLine().Split(' ');
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);

            if (m <= 0 || n <= 0)
            {
                counter = false;
                break;
            }

            int minorNumber = Math.Min(m, n);
            int greaterNumber = Math.Max(m, n);

            for (int i = minorNumber; i <= greaterNumber; i++)
            {
                Console.Write($"{i} ");
                totalValue += i;
            }
            Console.WriteLine($"Sum={totalValue}");
            totalValue = 0;
        }
    }
}