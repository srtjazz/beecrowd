using System;

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