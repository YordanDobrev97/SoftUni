using System;

namespace _06.Pedometer
{
    class Program
    {
        static void Main()
        {
            int unit = 1609;
            int meters = int.Parse(Console.ReadLine());
            double miles = meters * unit;

            Console.WriteLine(miles);
        }
    }
}
