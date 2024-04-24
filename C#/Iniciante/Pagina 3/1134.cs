using System;

//Tipo de Combust�vel

//Um Posto de combust�veis deseja determinar qual de seus produtos tem a prefer�ncia de seus clientes. Escreva um
//algoritmo para ler o tipo de combust�vel abastecido (codificado da seguinte forma: 1.�lcool 2.Gasolina 3.Diesel 4.Fim).
//Caso o usu�rio informe um c�digo inv�lido (fora da faixa de 1 a 4) deve ser solicitado um novo c�digo (at� que seja v�lido).
//O programa ser� encerrado quando o c�digo informado for o n�mero 4.

//Entrada
//A entrada cont�m apenas valores inteiros e positivos.

//Sa�da
//Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combust�vel,
//conforme exemplo.

class URI
{

    static void Main(string[] args)
    {
        int alcohol = 0;
        int gasoline = 0;
        int diesel = 0;

        int code = 0;

        while (code != 4)
        {
            code = int.Parse(Console.ReadLine());
            while (code < 1 || code > 4)
            {
                code = int.Parse(Console.ReadLine());
            }
            switch (code)
            {
                case 1: alcohol++; break;
                case 2: gasoline++; break;
                case 3: diesel++; break;
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcohol);
        Console.WriteLine("Gasolina: " + gasoline);
        Console.WriteLine("Diesel: " + diesel);
    }



}