using System;
using System.Linq;

namespace GenerateCombinations
{
    public class GenCombinations
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = int.Parse(Console.ReadLine());
            int[] data = new int[k];

            int border = -1;
            int index = 0;
            Combination(nums, data, index, border);
        }

        private static void Combination(int[] set, int[] vector, int index, int border)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = border + 1; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    Combination(set, vector, index + 1, i);
                }
            }
        }
    }
}