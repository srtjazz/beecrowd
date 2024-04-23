using System;

class URI
{

    static void Main(string[] args)
    {
        int counter = 0;
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; counter < n; i+=4)
        {
            Console.WriteLine($"{i} {i+1} {i+2} PUM");
            counter++;
        }
    }

}