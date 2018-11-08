using System;

class Program
{
    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());

        double killometers = meters * 0.001;

        Console.WriteLine($"{killometers:f2}");
    }
}

