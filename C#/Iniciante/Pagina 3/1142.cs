using System;

//PUM

//Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas
//na execução do programa.

//Entrada
//O arquivo de entrada contém um número inteiro positivo N.

//Saída
//Imprima a saída conforme o exemplo fornecido.

class URI
{

    static void Main(string[] args)
    {
        int counter = 0;
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; counter < n; i+=4)
        {
            Console.WriteLine($"{i} {i+1} {i+2} PUM");
            counter++;
        }
    }

}