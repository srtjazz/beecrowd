using System;

//Intervalo 2

//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo,
//mostrando essas informações.

//Entrada
//A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
//Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 

//Saída
//Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.


class URI
{

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int numbersIn = 0;
        int numbersOut = 0;

        for (int i = 0; i < number; i++)
        {
            int value = int.Parse(Console.ReadLine());
            if (value >= 10 && value <= 20)
            {
                numbersIn++;
            }
            else
            {
                numbersOut++;
            }
        }

        Console.WriteLine($"{numbersIn} in\n" +
            $"{numbersOut} out");

    }

}