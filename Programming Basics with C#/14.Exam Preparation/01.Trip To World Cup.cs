using System;
class Program
{
    static void Main()
    {
        double costOfTravel = double.Parse(Console.ReadLine());
        double returnPrice = double.Parse(Console.ReadLine());
        double ticketPriceMatch = double.Parse(Console.ReadLine());
        int numberMatches = int.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        double totalSum = 6 * (costOfTravel + returnPrice);
        totalSum = totalSum - (totalSum * (discount / 100.0));

        double totalSumMatch = 6 * numberMatches * ticketPriceMatch;
        double sum = totalSum + totalSumMatch;

        Console.WriteLine($"Total sum: {sum:f2} lv.");
        Console.WriteLine($"Each friend has to pay {sum / 6:f2} lv.");
    }
}
