using System;

//PUM

//Escreva um programa que leia um valor inteiro N. Este N � a quantidade de linhas de sa�da que ser�o apresentadas
//na execu��o do programa.

//Entrada
//O arquivo de entrada cont�m um n�mero inteiro positivo N.

//Sa�da
//Imprima a sa�da conforme o exemplo fornecido.

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