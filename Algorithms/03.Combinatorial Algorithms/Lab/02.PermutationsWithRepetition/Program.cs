using System;
using System.Collections.Generic;

namespace _02.PermutationsWithRepetition
{
    public class Program
    {
        private static string[] permutations;

        public static void Main()
        {
            permutations = Console.ReadLine().Split();
            int start = 0;
            PermuteWithRepetitions(start);
            //int end = permutations.Length - 1;
            //PermuteWithRepetitions(start, end);
        }

        /// <summary>
        /// Generate Permutations with repetitions without HashSet, using more complex approach
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void PermuteWithRepetitions(int start, int end)
        {
            Console.WriteLine(string.Join(" ", permutations));

            for (int left = end - 1; left >= start; left--)
            {
                for (int right = left + 1; right <= end; right++)
                {
                    if (permutations[left] != permutations[right])
                    {
                        Swap(left, right);
                        PermuteWithRepetitions(left + 1, end);
                    }
                }

                //returns everything to its original state to generate new permutation
                var first = permutations[left];
                for (int i = left; i < end - 1; i++)
                {
                    permutations[i] = permutations[i + 1];
                }
                permutations[end] = first;
            }
        }

        /// <summary>
        /// Generate Permutations with repetitions using HashSet
        /// </summary>
        /// <param name="start"></param>
        public static void PermuteWithRepetitions(int start)
        {
            if (start >= permutations.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            PermuteWithRepetitions(start + 1);

            var used = new HashSet<string> {  permutations[start] };

            for (int i = start + 1; i < permutations.Length; i++)
            {
                if (!used.Contains(permutations[i]))
                {
                    used.Add(permutations[i]);
                    Swap(start, i);
                    PermuteWithRepetitions(start + 1);
                    Swap(start, i);
                }
            }
        }

        private static void Swap(int left, int right)
        {
            string temp = permutations[left];
            permutations[left] = permutations[right];
            permutations[right] = temp;
        }
    }
}