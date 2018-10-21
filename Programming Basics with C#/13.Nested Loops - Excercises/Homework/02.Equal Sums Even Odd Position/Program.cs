using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            int number = i;
            for (int m = 1; m <= 6; m++)
            {
                int lastDigit = number % 10;
                if (m % 2 != 0)
                {
                    oddSum += lastDigit;
                }
                else
                {
                    evenSum += lastDigit;
                }
                number /= 10;
            }
            if (oddSum == evenSum)
            {
                Console.Write(i + " ");
            }
            oddSum = 0;
            evenSum = 0;
        }
    }
}

