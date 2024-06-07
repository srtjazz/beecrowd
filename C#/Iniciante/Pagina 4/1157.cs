using System;

//Divisores I

//Ler um número inteiro N e calcular todos os seus divisores.

//Entrada
//O arquivo de entrada contém um valor inteiro.

//Saída
//Escreva todos os divisores positivos de N, um valor por linha.

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
            }

        }
    }

}