using System;
using System.Numerics;

namespace _07.NChooseKCount
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = Factorial(n) / (Factorial(n - k) * Factorial(k));
            Console.WriteLine(result);
        }

        public static BigInteger Factorial(int num)
        {
            BigInteger result = 1;

            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }       
}