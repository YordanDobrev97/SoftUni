using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sumDigits = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;
            sumDigits += lastDigit;
            number /= 10;
        }

        Console.WriteLine(sumDigits);
    }
}

