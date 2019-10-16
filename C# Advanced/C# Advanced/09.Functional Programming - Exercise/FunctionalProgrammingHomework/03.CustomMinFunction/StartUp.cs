using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minNumber = x =>
            {
                int minValue = int.MaxValue;

                foreach (var item in x)
                {
                    if (item < minValue)
                    {
                        minValue = item;
                    }
                }
                return minValue;
            };

            int min = minNumber(numbers);
            Console.WriteLine(min);
        }
    }
}
