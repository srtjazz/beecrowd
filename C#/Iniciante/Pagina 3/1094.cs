using System;

//Experiências

//Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda
//para organizar os experimentos de um laboratório o qual ela é responsável. Ela quer saber no
//final do ano, quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.

//Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter
//estas informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de
//cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento.

//Entrada
//A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir.
//Cada caso de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias
//utilizadas e um caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).

//Saída
//Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de
//cada uma em relação ao total de cobaias utilizadas, sendo que o percentual deve ser apresentado com
//dois dígitos após o ponto.

class URI
{

    static void Main(string[] args)
    {
        int casesQuantity = int.Parse(Console.ReadLine());
        int guineaPigsTotal = 0;
        int totalRats = 0;
        int totalFrogs = 0;
        int totalBunnies = 0;

        for (int i = 0; i < casesQuantity; i++)
        {
            string[] values = Console.ReadLine().Split();
            int quantity = int.Parse(values[0]);
            char type = char.Parse(values[1]);

            guineaPigsTotal += quantity;

            switch (type)
            {
                case 'C':
                    totalBunnies += quantity;
                    break;
                case 'R':
                    totalRats += quantity;
                    break;
                case 'S':
                    totalFrogs += quantity;
                    break;
            }
        }
        double percentualBunnies = (double)totalBunnies / guineaPigsTotal * 100.0;
        double percentualRats = (double)totalRats / guineaPigsTotal * 100.0;
        double percentualFrogs = (double)totalFrogs / guineaPigsTotal * 100.0;

        Console.WriteLine($"Total: {guineaPigsTotal} cobaias\n" +
            $"Total de coelhos: {totalBunnies}\n" +
            $"Total de ratos: {totalRats}\n" +
            $"Total de sapos: {totalFrogs}\n" +
            $"Percentual de coelhos: {percentualBunnies:F2} %\n" +
            $"Percentual de ratos: {percentualRats:F2} %\n" +
            $"Percentual de sapos: {percentualFrogs:F2} %");
    }

}