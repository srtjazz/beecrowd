using System;

//Soma de Pares Consecutivos

//O programa deve ler um valor inteiro X indefinidas vezes. (O programa ir� parar quando o valor de X for igual a 0).
//Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X , se for par. Se o valor
//de entrada for 4, por exemplo, a sa�da deve ser 40, que � o resultado da opera��o: 4 + 6 + 8 + 10 + 12, enquanto
//que se o valor de entrada for 11, por exempo, a sa�da deve ser 80, que � a soma de 12+14+16+18+20.

//Entrada
//O arquivo de entrada cont�m muitos valores inteiros. O �ltimo valor do arquivo � zero.

//Sa�da
//Imprima a saida conforme a explica��o acima e o exemplo abaixo.

class URI
{

    static void Main(string[] args)
    {
        int x;
        while ((x = int.Parse(Console.ReadLine())) != 0)
        {
            int result = 0;

            for (int i = 0; i < 5; x++)
            {
                if (x % 2 == 0)
                {
                    result += x;
                    i++;
                }
            }

            Console.WriteLine(result);
        }
    }

}