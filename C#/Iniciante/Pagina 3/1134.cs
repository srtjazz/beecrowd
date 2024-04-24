using System;

//Tipo de Combustível

//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um
//algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).
//Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido).
//O programa será encerrado quando o código informado for o número 4.

//Entrada
//A entrada contém apenas valores inteiros e positivos.

//Saída
//Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível,
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