using System;

namespace _03.RecursiveFibonacci
{
    public class RecursiveFibonacci
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int fibonacci = Fibonacci(number);
            Console.WriteLine(fibonacci);
        }

        private static int Fibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
