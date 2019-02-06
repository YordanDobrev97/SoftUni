using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int maxCount = 1;
        int currentCount = 1;
        int value = 1;

        int currentElement = 0;
        for (int index = 0; index < array.Length - 1; index++)
        {
            currentElement = array[index];
            int nextElement = array[index + 1];

            if (currentElement == nextElement)
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    value = currentElement;
                }
                currentCount = 1;
            }
        }

        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            value = currentElement;
        }

        for (int i = 0; i < maxCount; i++)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine();
    }
}

