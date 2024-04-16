using System;

class URI
{

    static void Main(string[] args)
    {
        int casesQuantity = int.Parse(Console.ReadLine());

        for (int i = 0; i < casesQuantity; i++)
        {
            string[] values = Console.ReadLine().Split();
            double number1 = double.Parse(values[0]);
            double number2 = double.Parse(values[1]);
            double result = 0;
            if (number2 == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            if (number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine($"{result:F1}");
            }
        }
    }

}