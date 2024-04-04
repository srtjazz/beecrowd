using System;

//Pares, Ímpares, Positivos e Negativos

//Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.

//Entrada
//O arquivo de entrada contém 5 valores inteiros quaisquer.

//Saída
//Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.

class URI
{

    static void Main(string[] args)
    {

        int pairQuantity = 0;
        int unpairedQuantity = 0;
        int positiveQuantity = 0;
        int negativeQuantity = 0;

        for (int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                pairQuantity++;
            }
            if (number % 2 != 0)
            {
                unpairedQuantity++;
            }
            if (number > 0)
            {
                positiveQuantity++;
            }
            if (number < 0)
            {
                negativeQuantity++;
            }
        }

        Console.WriteLine($"{pairQuantity} valor(es) par(es)\n" +
            $"{unpairedQuantity} valor(es) impar(es)\n" +
            $"{positiveQuantity} valor(es) positivo(s)\n" +
            $"{negativeQuantity} valor(es) negativo(s)");

    }

}