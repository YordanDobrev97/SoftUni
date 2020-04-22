using System;

namespace CombinationsWithoutRepetition
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int index = 0;
            int initialValue = 1;
            int[] array = new int[k];

            GenerateCombinationWithoutRepetition(index, array, n, initialValue);
        }

        private static void GenerateCombinationWithoutRepetition(int index, int[] array, int n, int value)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = value; i <= n; i++)
            {
                array[index] = i;
                GenerateCombinationWithoutRepetition(index + 1, array, n, i + 1);
            }
        }
    }
}
