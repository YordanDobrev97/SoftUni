using System;

namespace Factorial
{
    public class RecursiveFactorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int resultFactorial = GetFactorial(n);
			Console.WriteLine($"{resultFactorial}");
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
