using System;

namespace _01.Reversed_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
