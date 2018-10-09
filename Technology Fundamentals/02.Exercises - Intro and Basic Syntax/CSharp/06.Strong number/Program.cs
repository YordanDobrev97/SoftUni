using System;

namespace _06.Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            long factorialSum = 0;
            long temp = number;
            while (temp > 0)
            {
                long lastDigit = temp % 10;
                long factorial = Factorial(lastDigit);
                factorialSum += factorial;
                temp /= 10;
            }

            if (factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static long Factorial(long number)
        {
            long factorial = 1;

            for (int i = 2; i <=number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
