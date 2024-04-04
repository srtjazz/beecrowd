using System;

//Intervalo 2

//Leia um valor inteiro N. Este valor ser� a quantidade de valores inteiros X que ser�o lidos em seguida.
//Mostre quantos destes valores X est�o dentro do intervalo [10,20] e quantos est�o fora do intervalo,
//mostrando essas informa��es.

//Entrada
//A primeira linha da entrada cont�m um valor inteiro N (N < 10000), que indica o n�mero de casos de teste.
//Cada caso de teste a seguir � um valor inteiro X (-107 < X <107).
 

//Sa�da
//Para cada caso, imprima quantos n�meros est�o dentro (in) e quantos valores est�o fora (out) do intervalo.


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