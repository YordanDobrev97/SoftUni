using System;
class TriangleArea
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = side * height / 2;

        Console.WriteLine($"Triangle area = {Math.Round(area, 2)}");
    }
}

