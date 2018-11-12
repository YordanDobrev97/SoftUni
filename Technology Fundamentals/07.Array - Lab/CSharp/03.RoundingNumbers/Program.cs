using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        double[] roundingNumbers = numbers.Select(el => Math.Round(el, MidpointRounding.AwayFromZero)).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"{numbers[i]} => {roundingNumbers[i]}");
        }
    }
}
