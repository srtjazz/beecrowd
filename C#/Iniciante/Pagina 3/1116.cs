using System;

//Dividindo X por Y

//Escreva um algoritmo que leia 2 n�meros e imprima o resultado da divis�o do primeiro pelo segundo. Caso n�o for poss�vel
//mostre a mensagem �divisao impossivel� para os valores em quest�o.

//Entrada
//A entrada cont�m um n�mero inteiro N. Este N ser� a quantidade de pares de valores inteiros (X e Y) que ser�o lidos em seguida.

//Sa�da
//Para cada caso mostre o resultado da divis�o com um d�gito ap�s o ponto decimal, ou �divisao impossivel� caso n�o seja
//poss�vel efetuar o c�lculo.

//Obs.: Cuide que a divis�o entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)

class URI
{

    static void Main(string[] args)
    {
        int casesQuantity = int.Parse(Console.ReadLine());

        for (int i = 0; i < casesQuantity; i++)
        {
            string[] values = Console.ReadLine().Split();
            double number1 = double.Parse(values[0]);
            double number2 = double.Parse(values[1]);
            double result = 0;
            if (number2 == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            if (number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine($"{result:F1}");
            }
        }
    }

}