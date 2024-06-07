using System;

//Senha Fixa

//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta
//informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa a mensagem
//"Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 

//Entrada
//A entrada é composta por vários casos de testes contendo valores inteiros.

//Saída
//Para cada valor lido mostre a mensagem correspondente à descrição do problema.

class URI
{

    static void Main(string[] args)
    {
        int correctPassword = 2002;

        while (true)
        {
            int typedPassword = int.Parse(Console.ReadLine());

            if (typedPassword == correctPassword)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            Console.WriteLine("Senha Invalida");
        }
    }

}