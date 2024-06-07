using System;

//Grenais

//A Federa��o Ga�cha de Futebol contratou voc� para escrever um programa para fazer uma estat�stica do resultado de v�rios
//GRENAIS. Escreva um programa para ler o n�mero de gols marcados pelo Inter e pelo Gr�mio em um GRENAL. Logo ap�s escrever
//a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se a resposta for 1, o algoritmo deve ser executado
//novamente solicitando o n�mero de gols marcados pelos times em uma nova partida, caso contr�rio deve ser encerrado imprimindo:

//-Quantos GRENAIS fizeram parte da estat�stica.
//- O n�mero de vit�rias do Inter.
//- O n�mero de vit�rias do Gr�mio.
//- O n�mero de Empates.
//- Uma mensagem indicando qual o time que venceu o maior n�mero de GRENAIS (ou "Nao houve vencedor", caso termine empatado).

//Entrada
//O arquivo de entrada cont�m 2 valores inteiros, correspondentes aos gols marcados pelo Inter e pelo Gr�mio respectivamente.
//Em seguida h�ver� um inteiro (1 ou 2), correspondente � repeti��o do programa.

//Sa�da
//Ap�s cada leitura dos gols, deve ser impressa a mensagem "Novo grenal (1-sim 2-nao)". Quando o algoritmo for encerrado devem
//ser mostradas as estat�sticas conforme a descri��o apresentada acima. Obs: a palavra "Gremio" deve ser impressa sem acento.

class URI
{

    static void Main(string[] args)
    {
        int numberConfirmation = 1;
        int interWins = 0;
        int gremioWins = 0;
        int drawQuantity = 0;
        int grenaisCounter = 0;

        while (numberConfirmation == 1)
        {
            string[] values = Console.ReadLine().Split();
            int interGoals = int.Parse(values[0]);
            int gremioGoals = int.Parse(values[1]);

            if (interGoals > gremioGoals)
            {
                interWins++;
            }
            if (gremioGoals > interGoals)
            {
                gremioWins++;
            }
            if (interGoals == gremioGoals)
            {
                drawQuantity++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            numberConfirmation = int.Parse(Console.ReadLine());
            grenaisCounter++;
            if (numberConfirmation == 2)
            {
                break;
            }
            while (numberConfirmation != 1 && numberConfirmation != 2)
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                numberConfirmation = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine($"{grenaisCounter} grenais\n" +
            $"Inter:{interWins}\n" +
            $"Gremio:{gremioWins}\n" +
            $"Empates:{drawQuantity}");
        if (interWins > gremioWins)
        {
            Console.WriteLine("Inter venceu mais");
        }
        if (gremioWins > interWins)
        {
            Console.WriteLine("Gremio venceu mais");
        }
    }

}