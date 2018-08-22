using System;

namespace _03.Number_sequence
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            int max = int.MinValue;
            int min = int.MaxValue;
            
            while (line != "END")
            {
                int number = int.Parse(line);

                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
