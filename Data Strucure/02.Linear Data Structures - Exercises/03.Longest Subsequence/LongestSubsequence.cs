using System;
using System.Collections.Generic;
using System.Linq;

class LongestSubsequence
{
    // solution 80/100
    static void Solution1()
    {
        var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        List<int> nums = new List<int>();

        int currentElement = 0;
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            currentElement = sequence[i];
            int nextElement = sequence[i + 1];

            if (currentElement == nextElement)
            {
                nums.Add(currentElement);
            }
            //else
            //{
            //    if (nums.Contains(currentElement))
            //    {
            //        nums.Add(currentElement);
            //    }
            //}
        }

        if (nums.Contains(currentElement))
        {
            nums.Add(currentElement);
        }
        int number = 1;
        int count = 1;
        int maxCount = 1;

        int indx = 0;
        for (indx = 0; indx < nums.Count - 1; indx++)
        {
            if (nums[indx] == nums[indx + 1])
            {
                count++;
            }
            else
            {
                if (maxCount < count)
                {
                    maxCount = count;
                    count = 1;
                    number = nums[indx];
                }
            }
        }
        if (maxCount < count)
        {
            maxCount = count;
            count = 1;
            number = nums[indx];
        }
        // special case
        if (number == 1 && sequence.Length == 1)
        {
            number = 0;
        }
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int currentCount = 1;
        int maxCount = 1;
        int number = input[0];
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i].Equals(input[i + 1]))
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    number = input[i];
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 1;
            }
        }
        //special case
        if (input[0] == 0)
        {
            number = 0;
        }

        for (int i = 0; i < maxCount; i++)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}

