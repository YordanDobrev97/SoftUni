using System;
using System.Collections.Generic;
using System.Linq;
class CountOfOccurrences
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        Dictionary<int, int> countOccurrences = new Dictionary<int, int>();

        for (int i = 0; i < input.Count; i++)
        {
            if (!countOccurrences.ContainsKey(input[i]))
            {
                countOccurrences.Add(input[i], 0);
            }
            countOccurrences[input[i]]++;
        }

        countOccurrences = countOccurrences.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
        foreach (var item in countOccurrences)
        {
            Console.WriteLine($"{item.Key} -> {item.Value} times");
        }
    }
}

