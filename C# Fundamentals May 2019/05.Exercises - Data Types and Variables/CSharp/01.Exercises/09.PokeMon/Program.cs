using System;

class Program
{
    static void Main()
    {
        int power = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());

        int countTarget = 0;
        int half = power / 2;
        while (power >= distance)
        {
            power = power - distance;
            countTarget++;
            
            if (half == power && exhaustionFactor > 0)
            {
                power = power / exhaustionFactor;
            }
        }
        Console.WriteLine(power);
        Console.WriteLine(countTarget);
    }
}
