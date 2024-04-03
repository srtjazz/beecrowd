using System;

//Soma de Impares Consecutivos I

//Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos n�meros impares entre eles.

//Entrada
//O arquivo de entrada cont�m dois valores inteiros.

//Sa�da
//O programa deve imprimir um valor inteiro. Este valor � a soma dos valores �mpares que est�o entre os valores
//fornecidos na entrada que dever� caber em um inteiro.

class URI
{

    static void Main(string[] args)
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int totalValue = 0;

        if (numberOne < numberTwo)
        {
            for (int i = numberOne + 1; i < numberTwo; i++)
            {
                if (i % 2 != 0)
                {
                    totalValue += i;
                }
            }

        }
        else
        {
            for (int i = numberTwo + 1; i < numberOne; i++)
            {
                if (i % 2 != 0)
                {
                    totalValue += i;
                }
            }
        }

        Console.WriteLine($"{totalValue}");

    }

}