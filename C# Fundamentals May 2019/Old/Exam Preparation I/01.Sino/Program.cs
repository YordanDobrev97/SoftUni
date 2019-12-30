using System;
using System.Globalization;

namespace _01.Sino
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var format = "H:m:s";
            DateTime dt = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
            var numberSteps = ulong.Parse(Console.ReadLine());
            var secondsSteps = ulong.Parse(Console.ReadLine());

            numberSteps *= secondsSteps;
            ulong day = 24 * 60 * 60;
            numberSteps = numberSteps % day;

            dt = dt.AddSeconds(numberSteps);
            Console.WriteLine($"Time Arrival: {dt.Hour.ToString("D2")}:{dt.Minute.ToString("D2")}:{dt.Second.ToString("D2")}");
        }
    }
}
