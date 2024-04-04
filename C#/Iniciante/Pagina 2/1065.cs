using System;

//Pares entre Cinco Números

//Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

//Entrada
//O arquivo de entrada contém 5 valores inteiros quaisquer.

//Saída
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