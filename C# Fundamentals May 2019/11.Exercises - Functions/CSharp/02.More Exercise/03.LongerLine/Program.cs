using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main()
        {
            decimal[] points = new decimal[8];

            for (int i = 0; i < points.Length; i++)
            {
                decimal value = decimal.Parse(Console.ReadLine());
                points[i] = value;
            }

            decimal resultX1 = 0;
            decimal resultY1 = 0;
            decimal resultX2 = 0;
            decimal resultY2 = 0;

            decimal maxDistance = decimal.MinValue;

            for (int i = 0; i < points.Length; i+=4)
            {
                decimal x1 = points[i];
                decimal y1 = points[i + 1];
                decimal x2 = points[i + 2];
                decimal y2 = points[i + 3];

                decimal distance = Distance(x1,y1,x2,y2);

                if (distance >= maxDistance)
                {
                    maxDistance = distance;
                    resultX1 = x1;
                    resultY1 = y1;
                    resultX2 = x2;
                    resultY2 = y2;
                }
            }

            Console.WriteLine($"({resultX2}, {resultY2})({resultX1}, {resultY1})");
        }
        static decimal Distance(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            return Pow2(x1 - x2) + Pow2(y1 - y2);
        }

        static decimal Pow2(decimal x)
        {
            return x * x;
        }
    }
}
