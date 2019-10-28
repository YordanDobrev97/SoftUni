namespace _04.SearchingAlgorithms
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = BinarySearch(array, 0, array.Length, 546545);
            Console.WriteLine(result);
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(new string('-', 60));
            stopwatch = new Stopwatch();
            stopwatch.Start();

            int originalSearch = Array.BinarySearch(array, 0, array.Length, 546545);
            Console.WriteLine(originalSearch);
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static int BinarySearch(int[] array, int index, int arrayLength, int value)
        {
            while (index <= arrayLength)
            {
                int middle = (arrayLength + index) / 2;

                if (array[middle] > value)
                {
                    arrayLength = middle - 1;
                }
                else if (array[middle] < value)
                {
                    index = middle + 1;
                }
                else
                {
                    return middle;
                }
            }

            throw new InvalidOperationException("Item not found!");
        }
    }
}
