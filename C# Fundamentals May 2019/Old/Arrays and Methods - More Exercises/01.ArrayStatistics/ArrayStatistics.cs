using System;
using System.Linq;
public class ArrayStatistics
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
             .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

        int min = GetMin(numbers);
        int max = GetMax(numbers);
        int sum = GetSum(numbers);
        double average = GetAverage(numbers);

        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
    }

    public static int GetMin(int[] numbers)
    {
        int min = int.MaxValue;

        foreach (var number in numbers)
        {
            if (min > number)
            {
                min = number;
            }
        }

        return min;
    }

    public static int GetMax(int[] numbers)
    {
        int max = int.MinValue;

        foreach (var number in numbers)
        {
            if (max < number)
            {
                max = number;
            }
        }

        return max;
    }

    public static int GetSum(int[] numbers)
    {
        int sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    public static double GetAverage(int[] numbers)
    {
        int sum = GetSum(numbers);
        return (double)sum / numbers.Length;
    }
}

