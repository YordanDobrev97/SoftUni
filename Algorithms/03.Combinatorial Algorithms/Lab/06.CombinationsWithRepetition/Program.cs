using System;

namespace _06.CombinationsWithRepetition
{
    public class Program
    {
        private static string[] elements;
        private static string[] combinations;
        private static int countCombinations;

        public static void Main()
        {
            elements = Console.ReadLine().Split();
            countCombinations = int.Parse(Console.ReadLine());
            combinations = new string[countCombinations];

            Combinations(0, 0);
        }

        public static void Combinations(int index, int start)
        {
            if (index >= countCombinations)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                combinations[index] = elements[i];
                Combinations(index + 1, i);
            }
        }
    }
}