using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ')
            .Select(int.Parse)
            .ToArray();

        bool isFoundEqualSum = false;

        for (int i = 0; i < array.Length; i++)
        {
            // find left sum
            int leftSum = 0;

            for (int leftIndex = i - 1; leftIndex >= 0; leftIndex--)
            {
                leftSum += array[leftIndex];
            }

            // find right sum
            int rightSum = 0;

            for (int rightIndex = i + 1; rightIndex <array.Length; rightIndex++)
            {
                rightSum += array[rightIndex];
            }

            if (leftSum == rightSum)
            {
                isFoundEqualSum = true;
                Console.WriteLine(i);
                break;
            }
        }

        if (!isFoundEqualSum)
        {
            Console.WriteLine("no");
        }
    }
}

