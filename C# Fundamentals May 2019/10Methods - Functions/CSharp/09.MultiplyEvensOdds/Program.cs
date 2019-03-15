using System;

namespace _09.MultiplyEvensOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int evenDigitSum = GetSumEvenDigits(number);
            int oddDigitSum = GetSumOddDigits(number);
            int multiply = MupltiplySums(evenDigitSum, oddDigitSum);
            Console.WriteLine(multiply);

        }

        private static int MupltiplySums(int evenDigitSum, int oddDigitSum)
        {
            return evenDigitSum * oddDigitSum;
        }

        private static int GetSumOddDigits(int number)
        {
            int sum = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }

        static int GetSumEvenDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
