using System;

namespace _03.VariationsWithoutRepetitions
{
    public class Program
    {
        private static string[] elements;
        private static string[] variations;
        private static bool[] used;
        private static int countVariations;

        public static void Main()
        {
            elements = Console.ReadLine().Split();
            countVariations = int.Parse(Console.ReadLine());

            variations = new string[countVariations];
            used = new bool[elements.Length];
            Variations(0);
        }

        public static void Variations(int index)
        {
            if (index >= countVariations)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    variations[index] = elements[i];
                    Variations(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
