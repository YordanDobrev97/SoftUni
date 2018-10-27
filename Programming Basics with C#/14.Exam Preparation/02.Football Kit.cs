using System;
class Program
{
    static void Main()
    {
        double priceTShirt = double.Parse(Console.ReadLine());
        double sum = double.Parse(Console.ReadLine());

        double priceShorts = priceTShirt * 0.75;
        double priceSocks = priceShorts * 0.20;
        double priceShoes = (priceTShirt + priceShorts) * 2;

        double totalSum = priceTShirt + priceShorts + priceSocks + priceShoes;

        totalSum = totalSum - (totalSum * 0.15);

        if (totalSum >= sum)
        {
            Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
            Console.WriteLine($"His sum is {totalSum:f2} lv.");
        }
        else
        {
            Console.WriteLine($"No, he will not earn the world-cup replica ball.");
            Console.WriteLine($"He needs {sum - totalSum:f2} lv. more.");
        }
    }
}
