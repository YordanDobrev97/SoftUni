using System;

class Program
{
    static void Main()
    {
        Console.Write("Length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        double volume = double.Parse(Console.ReadLine());

        double result = (length * width * volume) / 3;
        Console.WriteLine($"Pyramid Volume: {result:f2}");
    }
}

