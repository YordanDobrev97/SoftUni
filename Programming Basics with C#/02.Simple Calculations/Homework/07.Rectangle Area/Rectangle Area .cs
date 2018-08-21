using System;
class RectangleArea 
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double width = Math.Abs(x1 - x2);
        double height = Math.Abs(y2 - y1);

        Console.WriteLine(width * height);
        Console.WriteLine(2 * (width + height));
    }
}

