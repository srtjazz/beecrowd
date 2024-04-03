using System;

//Seis Números Ímpares

//Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha,
//inclusive o X ser for o caso.

//Entrada
//A entrada será um valor inteiro positivo.

//Saída
//A saída será uma sequência de seis números ímpares.

class URI
{

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());//8
        int counter = 0;

        while (counter < 6)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine($"{number}");
                counter++;

            }
            number++;
        }
    }

}