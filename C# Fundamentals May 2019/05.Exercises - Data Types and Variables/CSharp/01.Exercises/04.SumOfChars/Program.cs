using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sumChars = 0;

            for (int i = 0; i < number; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sumChars += symbol;
            }

            Console.WriteLine($"The sum equals: {sumChars}");
        }
    }
}
