using System;
using System.Linq;

namespace _05.GenCombinations
{
    class GenCombinations
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = int.Parse(Console.ReadLine());
            int[] data = new int[k];
            Combination(nums, data, 0, -1);
        }

        static void Combination(int[] set, int[] vector, int index, int border)
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
