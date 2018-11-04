using System;

namespace _05.Cat_Watch
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Basic(n);

            Middle(n);

            Basic(n);
        }

        private static void Middle(int n)
        {
            Console.Write(new string(' ', n - 1));
            Console.Write("//");
            Console.Write(new string(' ', n));
            Console.WriteLine("\\\\");

            int specialRowSymbol = (n - 4) / 3;
            for (int i = 0; i < n - 4; i++)
            {
                Console.Write(new string(' ', n - 2));
                Console.Write("||");
                Console.Write(new string(' ', n + 2));
                Console.Write("||");
                if (i == specialRowSymbol)
                {
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.Write(new string(' ', n - 1));
            Console.Write("\\\\");
            Console.Write(new string(' ', n));
            Console.WriteLine("//");
        }

        private static void Basic(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string(' ', n));
                Console.Write("||");
                Console.Write(new string('_', n - 2));
                Console.WriteLine("||");
            }
        }
    }
}
