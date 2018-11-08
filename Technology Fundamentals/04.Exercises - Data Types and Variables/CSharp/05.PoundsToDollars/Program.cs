using System;

class Program
{
    static void Main()
    {
        double dollars = double.Parse(Console.ReadLine());

        double pounds = dollars * 1.31;

        Console.WriteLine($"{pounds:f3}");
    }
}
