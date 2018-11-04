using System;

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int numberOfChocolate = int.Parse(Console.ReadLine());
        double quantityMilk = double.Parse(Console.ReadLine());

        double priceChocolate = numberOfChocolate * 0.65;
        double priceMilk = double.Parse($"{quantityMilk * 2.70:f2}");

        double numberMandarins = Math.Floor(numberOfChocolate - (numberOfChocolate * 0.35));
        numberMandarins *= 0.20;

        double totalPrice = double.Parse($"{priceChocolate + priceMilk + numberMandarins}");

        if (totalPrice <= budget)
        {
            Console.WriteLine($"You gotthis, {budget - totalPrice:f2} money left!");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} more!");
        }
    }
}

