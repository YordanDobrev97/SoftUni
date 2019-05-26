using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        int sumDigits = 0;

        for (int i = 0; i < number.Length; i++)
        {
            int digit = number[i] - '0';
            sumDigits += digit;
        }

        Console.WriteLine(sumDigits);
        //

        //while (number > 0)
        //{
        //    int lastDigit = number % 10;
        //    sumDigits += lastDigit;
        //    number /= 10;
        //}

        //Console.WriteLine(sumDigits);
    }
}

