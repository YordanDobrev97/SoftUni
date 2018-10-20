using System;
class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        string firstNumberAsString = firstNumber + "";

        if (firstNumberAsString.Length < 6 || secondNumber + "".Length < 6)
        {
            return;
        }

        while (firstNumber <  secondNumber)
        {
            int firstDigit = firstNumberAsString[0] - '0';
            int secondDigit = firstNumberAsString[1] - '0';
            int thirdDigit = firstNumberAsString[2] - '0';
            int fourthDigit = firstNumberAsString[3] - '0';
            int fifthDigit = firstNumberAsString[4] - '0';
            int sixthDigit = firstNumberAsString[5] - '0';

            int evenSum = secondDigit + fourthDigit + sixthDigit;
            int oddSum = firstDigit + thirdDigit + fifthDigit;

            if (evenSum == oddSum)
            {
                Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit}{fifthDigit}{sixthDigit} ");
            }
            firstNumber++;
            firstNumberAsString = firstNumber + "";
        }
        Console.WriteLine();
    }
}

