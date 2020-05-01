using System;

namespace _01.PermutationsWithoutRepetitions
{
    public class Program
    {
        private static string[] elements;

        public static void Main()
        {
            elements = Console.ReadLine().Split();
            
            Permute(0);
        }

        public static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            Permute(index + 1);
            for (int i = index + 1; i < elements.Length; i++)
            {
                Swap(index, i);
                Permute(index + 1);
                Swap(index, i);
            }
        }

        private static void Swap(int index, int i)
        {
            string temp = elements[index];
            elements[index] = elements[i];
            elements[i] = temp;
        }
    }
}