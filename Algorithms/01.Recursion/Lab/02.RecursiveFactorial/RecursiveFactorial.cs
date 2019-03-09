using System;

namespace _02.RecursiveFactorial
{
    class RecursiveFactorial
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int factorial = GetFactorial(n);
            Console.WriteLine($"Factorial = {factorial}");
        }

        public static int GetFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * GetFactorial(n - 1);
        }
    }
}
