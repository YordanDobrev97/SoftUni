using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double sum = input.Sum();
        double average = sum / input.Length;
        Console.WriteLine($"Sum={sum}; Average={average:f2}");
    }
}

