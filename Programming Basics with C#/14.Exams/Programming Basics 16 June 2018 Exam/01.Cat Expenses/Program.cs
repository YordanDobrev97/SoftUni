using System;

namespace _01.Cat_Expenses
{
    class Program
    {
        static void Main()
        {
            double priceBedOfCat = double.Parse(Console.ReadLine());
            double priceToiletCat = double.Parse(Console.ReadLine());
            
            double priceFood = priceToiletCat + (priceToiletCat * 0.25);
            double priceToys = priceFood - (priceFood * 0.50);
            double visitedVeterinarian = priceToys + (priceToys * 0.10);

            double totalConstMonth = priceToiletCat + priceFood
                + priceToys + visitedVeterinarian;

            double unforeseenCosts = totalConstMonth * 0.05;

            double costPerYear = priceBedOfCat + 12 * totalConstMonth + 12 * unforeseenCosts;
            Console.WriteLine($"{costPerYear:f2} lv.");
        }
    }
}
