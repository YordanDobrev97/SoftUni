using System;
using System.Linq;

class SortWords
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').ToList();

        input.Sort();

        Console.WriteLine(string.Join(" ", input));

    }
}

