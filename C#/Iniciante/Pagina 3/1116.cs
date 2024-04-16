using System;

//Dividindo X por Y

//Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível
//mostre a mensagem “divisao impossivel” para os valores em questão.

//Entrada
//A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

//Saída
//Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja
//possível efetuar o cálculo.

//Obs.: Cuide que a divisão entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)

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