using System;

namespace CombinationsWithRepetition
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

            GenerateCombinationWithRepetition(index, array, n, initialValue);
        }

        public static void GenerateCombinationWithRepetition(int index, int[] array, int n, int value)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = value; i <= n; i++)
            {
                array[index] = i;
                GenerateCombinationWithRepetition(index + 1, array, n, i);
            }
        }
    }
}
