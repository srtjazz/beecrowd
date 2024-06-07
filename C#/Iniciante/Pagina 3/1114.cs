using System;

//Senha Fixa

//Escreva um programa que repita a leitura de uma senha at� que ela seja v�lida. Para cada leitura de senha incorreta
//informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa a mensagem
//"Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta � o valor 2002. 

//Entrada
//A entrada � composta por v�rios casos de testes contendo valores inteiros.

//Sa�da
//Para cada valor lido mostre a mensagem correspondente � descri��o do problema.

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