using System;
using System.Numerics;

namespace _03.BigFactorial
{
    public class BigFactorial
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger bigInteger = Factorial(number);

            Console.WriteLine(bigInteger);
        }

        public static BigInteger Factorial(int number)
        {
            BigInteger bigInteger = 1;

            for (int i = 1; i <=number; i++)
            {
                bigInteger *= i;
            }

            return bigInteger;
        }
    }
}
