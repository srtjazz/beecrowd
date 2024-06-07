using System;

//Pares entre Cinco N�meros

//Fa�a um programa que leia 5 valores inteiros. Conte quantos destes valores digitados s�o pares e mostre esta informa��o.

//Entrada
//O arquivo de entrada cont�m 5 valores inteiros quaisquer.

//Sa�da
//Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.

class URI
{
    static void Main(string[] args)
    {
        int quantity = 0;
        for (int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                quantity++;
            }
        }

        Console.WriteLine($"{quantity} valores pares");
    }

}