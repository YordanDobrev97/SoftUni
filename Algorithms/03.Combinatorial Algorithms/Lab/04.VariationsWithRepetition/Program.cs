using System;

namespace _04.VariationsWithRepetition
{
    public class Program
    {
        private static string[] elements;
        private static string[] variations;
        private static int countVariations;

        public static void Main()
        {
            elements = Console.ReadLine().Split();
            countVariations = int.Parse(Console.ReadLine());

            variations = new string[countVariations];
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
                variations[index] = elements[i];
                Variations(index + 1);
            }
        }
    }
}