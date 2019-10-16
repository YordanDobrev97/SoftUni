using System;
using System.Linq;

namespace _04.AddVAT
{
    public class Program
    {
       public static void Main()
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Func<double, double> addVat = value => value + (value * 0.20);

            var resultPrices = prices.Select(addVat).ToArray();

            foreach (var price in resultPrices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
