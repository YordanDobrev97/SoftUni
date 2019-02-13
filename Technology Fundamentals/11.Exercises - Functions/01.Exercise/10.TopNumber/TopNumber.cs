using System;

namespace _10.TopNumber
{
    public class TopNumber
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sumDigit = SumDigit(i);

                if (sumDigit % 8 == 0 && ContainsOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsOddDigit(int i)
        {
            bool found = false;

            while (i > 0)
            {
                int digit = GetLastDigit(i);
                if (digit % 2 == 1)
                {
                    found = true;
                    break;
                }
                i /= 10;
            }


            return found;
        }

        private static int GetLastDigit(int i)
        {
            return i % 10;
        }

        private static int SumDigit(int i)
        {
            int sum = 0;

            while (i > 0)
            {
                int digit = GetLastDigit(i);
                sum += digit;
                i /= 10;
            }
            return sum;
        }
    }
}
