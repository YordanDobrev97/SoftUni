using System;
using System.Linq;

namespace _02.FromLeftRight
{
    public class FromLeftRight
    {
        public static void Main()
        {
            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                long[] elements = Console.ReadLine()
                    .Split(' ').Select(long.Parse).ToArray();

                long leftNumber = elements[0];
                long rightNumber = elements[1];

                long sum = 0;
                if (leftNumber > rightNumber)
                {
                    sum = sumDigitNumber(leftNumber);
                }
                else
                {
                    sum = sumDigitNumber(rightNumber);
                }

                Console.WriteLine(sum);
            }
        }

        public static long sumDigitNumber(long number)
        {
            long sum = 0;

            while (Math.Abs(number) > 0)
            {
                long digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return Math.Abs(sum);
        }
    }
}
