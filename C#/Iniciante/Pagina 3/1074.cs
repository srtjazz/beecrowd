using System;

//Par ou �mpar

//Leia um valor inteiro N. Este valor ser� a quantidade de valores que ser�o lidos em seguida. Para cada valor lido,
//mostre uma mensagem em ingl�s dizendo se este valor lido � par (EVEN), �mpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE).
//No caso do valor ser igual a zero (0), embora a descri��o correta seja (EVEN NULL), pois por defini��o zero � par, seu programa
//dever� imprimir apenas NULL.

//Entrada
//A primeira linha da entrada cont�m um valor inteiro N(N < 10000) que indica o n�mero de casos de teste. Cada caso de teste
//a seguir � um valor inteiro X (-107 < X <107).

//Sa�da
//Para cada caso, imprima uma mensagem correspondente, de acordo com o exemplo abaixo. Todas as letras dever�o ser mai�sculas
//e sempre dever� haver um espa�o entre duas palavras impressas na mesma linha.

class URI
{

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            int value = int.Parse(Console.ReadLine());
            if (value % 2 == 0 && value > 0)
            {
                Console.WriteLine("EVEN POSITIVE");
            }
            else if (value % 2 == 0 && value < 0)
            {
                Console.WriteLine("EVEN NEGATIVE");
            }
            else if (value % 2 != 0 && value > 0)
            {
                Console.WriteLine("ODD POSITIVE");
            }
            else if (value % 2 != 0 && value < 0)
            {
                Console.WriteLine("ODD NEGATIVE");

            }
            else
            {
                Console.WriteLine("NULL");
            }
        }

    }

}