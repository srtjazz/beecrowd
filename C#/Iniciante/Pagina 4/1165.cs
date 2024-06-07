using System;

//Número Primo

//Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 (um) e por ele mesmo. Por exemplo, o
//número 7 é primo, pois pode ser dividido apenas pelo número 1 e pelo número 7.

//Entrada
//A entrada contém vários casos de teste. A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 100), indicando
//o número de casos de teste da entrada. Cada uma das N linhas seguintes contém um valor inteiro X (1 < X ≤ 107),
//que pode ser ou não, um número primo.

//Saída
//Para cada caso de teste de entrada, imprima a mensagem “X eh primo” ou “X nao eh primo”, de acordo com a
//especificação fornecida.

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int result = 0;

            for (int j = 1; j <= x; j++)
            {
                if (x % j == 0)
                {
                    result++;
                }
            }
            if (result == 2)
            {
                Console.WriteLine($"{x} eh primo");
            }
            else
            {
                Console.WriteLine($"{x} nao eh primo");
            }

        }
    }

}