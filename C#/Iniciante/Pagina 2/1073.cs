using System;

//Quadrado de Pares

//Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.

//Entrada
//A entrada contém um valor inteiro N (5 < N < 2000).

//Saída
//Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.

//Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés de 1000000 o que ocasionará
//resposta errada. Neste caso, configure a precisão adequadamente para que isso não ocorra.

class URI
{

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());//6

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                int result = i * i;
                Console.WriteLine($"{i}^2 = {result}");
            }
        }

    }

}