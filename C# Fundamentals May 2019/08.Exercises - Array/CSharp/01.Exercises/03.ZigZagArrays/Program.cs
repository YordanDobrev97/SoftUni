using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        int[] firstArray = new int[count];
        int[] secondArray = new int[count];

        for (int i = 0; i < count; i++)
        {
            int[] values = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int firstValue = values[0];
            int secondValue = values[1];

            if (i % 2 == 1)
            {
                firstValue = values[1];
                secondValue = values[0];
            }

            firstArray[i] = firstValue;
            secondArray[i] = secondValue;
        }

        Console.WriteLine(string.Join(" ", firstArray));
        Console.WriteLine(string.Join(" ", secondArray));
    }
}

