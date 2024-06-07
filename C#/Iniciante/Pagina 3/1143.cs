using System;

//Quadrado e ao Cubo

//Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que
//serão apresentadas na execução do programa.

//Entrada
//O arquivo de entrada contém um número inteiro positivo N.

//Saída
//Imprima a saída conforme o exemplo fornecido.

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 1; counter < n; i++)
        {
            Console.WriteLine($"{i} {i*i} {i*i*i}");
            counter++;
        }

    }

}