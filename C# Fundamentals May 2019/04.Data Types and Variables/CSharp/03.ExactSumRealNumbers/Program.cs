using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        decimal result = 0M;
        for (int i = 0; i < number; i++)
        {
            decimal currentNumber = decimal.Parse(Console.ReadLine());
            result += currentNumber;
        }
        Console.WriteLine(result);
    }
}

