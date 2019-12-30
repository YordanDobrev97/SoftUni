using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            int middleLength = numbers.Count / 2;

            double left = 0;
            for (int i = 0; i < middleLength; i++)
            {
                int value = numbers[i];

                if (value == 0)
                {
                    left *= 0.8;
                }
                else
                {
                    left += value;
                }
            }

            double right = 0;
            for (int i = numbers.Count - 1; i >= numbers.Count / 2 + 1; i--)
            {
                int value = numbers[i];

                if (value == 0)
                {
                    right *= 0.8;
                }
                else
                {
                    right += value;
                }
            }

            string output = "The winner is {0} with total time: {1}";

            if (left < right)
            {
                output = string.Format(output, "left", left);    
            }
            else
            {
                output = string.Format(output, "right", right);
            }

            Console.WriteLine(output);
        }
    }
}
