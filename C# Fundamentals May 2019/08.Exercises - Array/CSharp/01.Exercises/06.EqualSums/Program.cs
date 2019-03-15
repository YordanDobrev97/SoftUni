using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ')
            .Select(int.Parse)
            .ToArray();

        bool foundEqualSum = false;
        for (int i = 1; i < array.Length; i++)
        {
            int leftSum = LeftSum(array, i);
            int rigthSum = RightSum(array, i);

            if (leftSum == rigthSum)
            {
                foundEqualSum = true;
                Console.WriteLine(i);
                break;
            }
        }
        if (array.Length == 1)
        {
            Console.WriteLine(0);
        }
        else if (!foundEqualSum)
        {
            Console.WriteLine("no");
        }
    }
    static int LeftSum(int[] array, int position)
    {
        int leftSum = 0;
        for (int i = position; i >= 0; i--)
        {
            leftSum += array[i];
        }
        return leftSum;
    }
    static int RightSum(int[] array, int position)
    {
        int rightSum = 0;

        for (int i = position; i < array.Length; i++)
        {
            rightSum += array[i];
        }

        return rightSum;
    }
}

