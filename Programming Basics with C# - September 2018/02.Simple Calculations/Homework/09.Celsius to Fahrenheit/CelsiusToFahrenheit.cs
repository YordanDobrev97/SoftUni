using System;
class CelsiusToFahrenheit
{
    static void Main()
    {
        double degress = double.Parse(Console.ReadLine());

        Console.WriteLine(degress * 1.8 + 32);
    }
}

