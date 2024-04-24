using System;

//Sequência Lógica

//Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas na execução do programa,
//seguindo a lógica do exemplo abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.

//Entrada
//O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).

//Saída
//Imprima a saída conforme o exemplo fornecido.

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int totalLines = n * 2;
        int counter = 0;

        for (int i = 1; counter < totalLines;)
        {
            Console.WriteLine($"{i} {i * i} {i * i * i}");
            Console.WriteLine($"{i} {(i * i) + 1} {(i * i * i) + 1}");
            i++;
            counter+=2;
        }
    }

}