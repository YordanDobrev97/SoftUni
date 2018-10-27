using System;
class Program
{
    static void Main()
    {
        string nameFan = Console.ReadLine();
        double budget = double.Parse(Console.ReadLine());
        int quantityBeer = int.Parse(Console.ReadLine());
        int quantityChips = int.Parse(Console.ReadLine());

        double totalPriceBeer = quantityBeer * 1.20;
        double priceChips = totalPriceBeer * 0.45;
        priceChips = Math.Ceiling(priceChips * quantityChips);

        double totalSum = totalPriceBeer + priceChips;

        if (totalSum <= budget)
        {
            Console.WriteLine($"{nameFan} bought a snack and has {budget - totalSum:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"{nameFan} needs {totalSum - budget:f2} more leva!");
        }
    }
}
