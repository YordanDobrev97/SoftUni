using System;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double result = Math.PI * radius * radius;
        Console.WriteLine("{0:f12}", Math.Round(result, 12));
    }
}

