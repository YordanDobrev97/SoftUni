using System;
class CirclePerimeterArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine($"Area = {area}");
        Console.WriteLine($"Perimeter = {perimeter}");
    }
}
