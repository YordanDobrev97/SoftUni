using System;
using System.Collections.Generic;
using System.Linq;

class RemoveOddOccurrences
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();

        for (int i = 0; i < input.Count; i++)
        {
            int counter = 0;
            int currentElement = input[i];

            for (int j = 0; j < input.Count; j++)
            {
                int next = input[j];

                if (currentElement == next)
                {
                    counter++;
                }
            }
            if (counter % 2 == 1)
            {
                input.RemoveAll(n => n == currentElement);
                i--;
            }
        }
        Console.WriteLine(string.Join(" ", input));
    }
}

