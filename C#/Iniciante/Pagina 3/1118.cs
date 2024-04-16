using System;

//V�rias Notas Com Valida��o

//Escreva um programa para ler as notas da primeira e a segunda avalia��o de um aluno. Calcule e imprima a m�dia semestral.
//O programa s� dever� aceitar notas v�lidas (uma nota v�lida deve pertencer ao intervalo [0,10]). Cada nota deve ser
//validada separadamente.

//No final deve ser impressa a mensagem �novo calculo (1-sim 2-nao)�, solicitando ao usu�rio que informe um c�digo (1 ou 2)
//indicando se ele deseja ou n�o executar o algoritmo novamente, (aceitar apenas os c�digo 1 ou 2). Se for informado o c�digo
//1 deve ser repetida a execu��o de todo o programa para permitir um novo c�lculo, caso contr�rio o programa deve ser encerrado.

//Entrada
//O arquivo de entrada cont�m v�rios valores reais, positivos ou negativos. Quando forem lidas duas notas v�lidas, deve ser
//lido um valor inteiro X . O programa deve parar quando o valor lido para este X for igual a 2.

//Sa�da
//Se uma nota inv�lida for lida, deve ser impressa a mensagem �nota invalida�. Quando duas notas v�lidas forem lidas, deve
//ser impressa a mensagem �media = � seguido do valor do c�lculo.

//Antes da leitura de X deve ser impressa a mensagem "novo calculo (1-sim 2-nao)" e esta mensagem deve ser apresentada
//novamente se o valor da entrada padr�o para X for menor do que 1 ou maior do que 2, conforme o exemplo abaixo.

//A m�dia deve ser impressa com dois d�gitos ap�s o ponto decimal.

class URI
{

    static void Main(string[] args)
    {
        int numberConfirmation = 1;

        while (numberConfirmation == 1)
        {
            double media = 0;

            for (int i = 0; i < 2;)
            {
                double studentNote = double.Parse(Console.ReadLine());

                if (studentNote < 0 || studentNote > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else if (studentNote >= 0 && studentNote <= 10)
                {
                    media += studentNote;
                    i++;
                }
            }

            Console.WriteLine($"media = {media/2:F2}");
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            numberConfirmation = int.Parse(Console.ReadLine());

            while (numberConfirmation !=1 && numberConfirmation != 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                numberConfirmation = int.Parse(Console.ReadLine());
            }
        }
    }
}