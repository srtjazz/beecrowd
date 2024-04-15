using System;

//Crescente e Decrescente

//Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma mensagem que indique
//se estes valores foram digitados em ordem crescente ou decrescente.

//Entrada
//A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y. A leitura deve ser encerrada ao
//ser fornecido valores iguais para X e Y.

//Saída
//Para cada caso de teste imprima “Crescente”, caso os valores tenham sido digitados na ordem crescente, caso contrário
//imprima a mensagem “Decrescente”.

class URI
{

    static void Main(string[] args)
    {
        while (true)
        {
            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);

            if (x < y)
            {
                Console.WriteLine("Crescente");
            }
            if (x > y)
            {
                Console.WriteLine("Decrescente");
            }
            if (x == y)
            {
                break;
            }


        }
    }

}