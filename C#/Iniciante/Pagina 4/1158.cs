using System;

//Soma de �mpares Consecutivos III

//Leia um valor inteiro N que � a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de
//dois inteiros X e Y. Voc� deve apresentar a soma de Y �mpares consecutivos a partir de X inclusive o pr�prio
//X se ele for �mpar. Por exemplo:
//para a entrada 4 5, a sa�da deve ser 45, que � equivalente �: 5 + 7 + 9 + 11 + 13
//para a entrada 7 4, a sa�da deve ser 40, que � equivalente �: 7 + 9 + 11 + 13

//Entrada
//A primeira linha de entrada � um inteiro N que � a quantidade de casos de teste que vem a seguir. Cada caso
//de teste consiste em uma linha contendo dois inteiros X e Y.

//Sa�da
//Imprima a soma dos consecutivos n�meros �mpares a partir do valor X.

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split();
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);
            int result = 0;

            for (int j = 0; j < y; x++)
            {
                if (x % 2 != 0)
                {
                    result += x;
                    j++;
                }
            }
            Console.WriteLine(result);
        }
    }

}