using System;

//Valida��o de Nota

//Fa�a um programa que leia as notas referentes �s duas avalia��es de um aluno. Calcule e imprima a m�dia semestral.
//Fa�a com que o algoritmo s� aceite notas v�lidas (uma nota v�lida deve pertencer ao intervalo [0,10]). Cada nota
//deve ser validada separadamente.

//Entrada
//A entrada cont�m v�rios valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas
//duas notas v�lidas.

//Sa�da
//Se uma nota inv�lida  for lida, deve ser impressa a mensagem "nota invalida".
//Quando duas notas v�lidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do c�lculo. O valor
//deve ser apresentado com duas casas ap�s o ponto decimal.

class URI
{

    static void Main(string[] args)
    {
        int counter = 0;
        double media = 0;

        while (counter < 2)
        {
            double studentNote = double.Parse(Console.ReadLine());

            if (studentNote < 0 || studentNote > 10)
            {
                Console.WriteLine("nota invalida");
            } else if (studentNote >= 0 && studentNote <= 10)
            {
                media += studentNote;
                counter++;
            }
        }

        Console.WriteLine($"media = {media/2:F2}");
    }

}