using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] firstArray = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] secondArray = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int indexDiff = 0;
        int sum = 0;
        bool hasAllEqualItems = true;

        int min = Math.Min(firstArray.Length, secondArray.Length);

        for (int i = 0; i < min; i++)
        {
            int elementFromFirstArray = firstArray[i];
            int elementFromSecondArray = secondArray[i];

            if (elementFromFirstArray != elementFromSecondArray)
            {
                hasAllEqualItems = false;
                indexDiff = i;
                break;
            }
            sum += elementFromFirstArray;
        }

        if (hasAllEqualItems)
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
        else
        {
            Console.WriteLine($"Arrays are not identical. Found difference at {indexDiff} index");
        }
    }
}

