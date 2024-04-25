using System;

class URI
{

    static void Main(string[] args)
    {
        string[] values = Console.ReadLine().Split(' ');
        int x = int.Parse(values[0]);
        int y = int.Parse(values[1]);

        for (int i = 1; i <= y; i++)
        {
            Console.Write($"{i}");
            if (i % x == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
    }

}