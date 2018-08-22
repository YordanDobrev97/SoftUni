using System;

namespace _07.Sequence_2k
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;

            while (number <=n)
            {
                Console.WriteLine(number);

                number = number * 2 + 1;
            }
        }
    }
}
