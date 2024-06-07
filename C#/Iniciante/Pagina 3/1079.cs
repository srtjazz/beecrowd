using System;
using System.Globalization;

//M�dias Ponderadas

//Leia 1 valor inteiro N, que representa o n�mero de casos de teste que vem a seguir. Cada caso
//de teste consiste de 3 valores reais, cada um deles com uma casa decimal. Apresente a m�dia ponderada
//para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor
//tem peso 3 e o terceiro valor tem peso 5.

//Entrada
//O arquivo de entrada cont�m um valor inteiro N na primeira linha. Cada N linha a seguir cont�m um caso
//de teste com tr�s valores com uma casa decimal cada valor.

//Sa�da
//Para cada caso de teste, imprima a m�dia ponderada dos 3 valores, conforme exemplo abaixo.

class URI
{

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            double n1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(values[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(values[2], CultureInfo.InvariantCulture);

            double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
            Console.WriteLine($"{media:F1}", CultureInfo.InvariantCulture);
        }
    }

}