using System;

//Quadrado de Pares

//Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 at� N, inclusive N, se for o caso.

//Entrada
//A entrada cont�m um valor inteiro N (5 < N < 2000).

//Sa�da
//Imprima o quadrado de cada um dos valores pares, de 1 at� N, conforme o exemplo abaixo.

//Tome cuidado! Algumas linguagens tem por padr�o apresentarem como sa�da 1e+006 ao inv�s de 1000000 o que ocasionar�
//resposta errada. Neste caso, configure a precis�o adequadamente para que isso n�o ocorra.

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