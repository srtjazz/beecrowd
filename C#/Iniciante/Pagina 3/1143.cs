using System;

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 1; counter < n; i++)
        {
            Console.WriteLine($"{i} {i*i} {i*i*i}");
            counter++;
        }

    }

}