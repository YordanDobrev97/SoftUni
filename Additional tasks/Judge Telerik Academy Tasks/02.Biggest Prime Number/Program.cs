using System;

namespace _02.Biggest_Prime_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int biggest = number;

            bool notFoundBiggestPrimeNumber = false;

            while (!notFoundBiggestPrimeNumber)
            {
                if (IsPrime(number))
                {
                    biggest = number;
                    notFoundBiggestPrimeNumber = true;
                }
                else
                {
                    number--;
                }
            }

            Console.WriteLine(biggest);
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i <=number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
