using System;

class Program
{
    static void Main()
    {
        string town = Console.ReadLine();
        long population = long.Parse(Console.ReadLine());
        double area = double.Parse(Console.ReadLine());

        Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
    }
}

