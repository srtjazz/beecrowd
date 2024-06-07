using System;

//Soma de Ímpares Consecutivos II

//Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y.
//Você deve apresentar a soma de todos os ímpares existentes entre X e Y.

//Entrada
//A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste em uma
//linha contendo dois inteiros X e Y.

//Saída
//Imprima a soma de todos valores ímpares entre X e Y.

//Exemplo de Entrada	Exemplo de Saída
//7                     

//4 5                   //0

//13 10                 //11

//6 4                   //5

//3 3                   //0

//3 5                   //0

//3 4                   //0

//3 8                   //12

class URI
{

    static void Main(string[] args)
    {
        int casesQuantity = int.Parse(Console.ReadLine());

        for (int i = 0; i < casesQuantity; i++)
        {
            string[] values = Console.ReadLine().Split();
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);
            int totalValue = 0;

            if (x < y)
            {
                for (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        totalValue += j;
                    }
                }

            }
            else
            {
                for (int j = y + 1; j < x; j++)
                {
                    if (j % 2 != 0)
                    {
                        totalValue += j;
                    }
                }
            }
            Console.WriteLine($"{totalValue}");
        }
    }

}