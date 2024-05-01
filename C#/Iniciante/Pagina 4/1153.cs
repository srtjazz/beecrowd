using System;

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i > 1;)
        {
            i--;
            n *= i;
        }

        Console.WriteLine(n);
    }

}