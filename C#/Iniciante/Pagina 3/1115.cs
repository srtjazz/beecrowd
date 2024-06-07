using System;

//Quadrante

//Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema cartesiano.
//Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas
//coordenadas for NULA (nesta situação sem escrever mensagem alguma).

//Entrada
//A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.

//Saída
//Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a coordenada lida,
//conforme o exemplo.

class URI
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);

            string result = verifyQuadrant(x, y);
            if (result == "")
            {
                break;
            }
            Console.WriteLine($"{result}");
        }
    }

    private static string verifyQuadrant(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            return "primeiro";
        }
        if (x < 0 && y > 0)
        {
            return "segundo";
        }
        if (x < 0 && y < 0)
        {
            return "terceiro";
        }
        if (x > 0 && y < 0)
        {
            return "quarto";
        }
        if (x == 0 || y == 0)
        {
            return "";
        }
        return "";
    }

}