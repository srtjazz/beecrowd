using System;

//Seis N�meros �mpares

//Leia um valor inteiro X. Em seguida apresente os 6 valores �mpares consecutivos a partir de X, um valor por linha,
//inclusive o X ser for o caso.

//Entrada
//A entrada ser� um valor inteiro positivo.

//Sa�da
//A sa�da ser� uma sequ�ncia de seis n�meros �mpares.

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