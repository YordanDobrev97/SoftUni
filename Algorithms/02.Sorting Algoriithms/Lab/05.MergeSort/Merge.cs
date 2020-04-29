using System;
using System.Linq;

namespace _05.MergeSort
{
    class Merge
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = MergeSort(numbers);

            Console.WriteLine(string.Join(" ", sorted));
        }

        public static int[] MergeSort(int[] collection)
        {
            if (collection.Length <= 1)
            {
                return collection;
            }

            int middleIndex = collection.Length / 2;
            int[] left = collection.Take(middleIndex).ToArray();
            int[] right = collection.Skip(middleIndex).ToArray();

            left = MergeSort(left);
            right = MergeSort(right);

            return Merging(left, right);
        }

        public static int[] Merging(int[] left, int[] right)
        {
            int[] newArray = new int[left.Length + right.Length];

            int indexLeft = 0;
            int indexRight = 0;
            int i = 0;

            while (indexLeft < left.Length && indexRight < right.Length)
            {
                if (left[indexLeft] > right[indexRight])
                {
                    newArray[i] = right[indexRight];
                    indexRight++;
                }
                else
                {
                    newArray[i] = left[indexLeft];
                    indexLeft++;
                }
                i++;
            }

            while (indexLeft < left.Length)
            {
                newArray[i] = left[indexLeft];
                i++;
                indexLeft++;
            }

            while (indexRight < right.Length)
            {
                newArray[i] = right[indexRight];
                i++;
                indexRight++;
            }

            return newArray;
        }
    }
}