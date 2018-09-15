using System;

namespace _15.Toy_Shop
{
    class Program
    {
        static void Main()
        {
            double puzzlePrice = 2.60;
            double speakingDollPrice = 3;
            double teddyBearPrice = 4.10;
            double minionPrice = 8.20;
            double trucksPrice = 2;

            double priceOfExcursion = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfSpeakingDolls = int.Parse(Console.ReadLine());
            int numberTeddyBreaks = int.Parse(Console.ReadLine());
            int numberMinions = int.Parse(Console.ReadLine());
            int numberTrucks = int.Parse(Console.ReadLine());

            double totalSum = numberOfPuzzles * puzzlePrice +
                numberOfSpeakingDolls * speakingDollPrice +
                numberTeddyBreaks * teddyBearPrice +
                numberMinions * minionPrice +
                numberTrucks * trucksPrice;

            double numberToys = numberOfPuzzles + numberOfSpeakingDolls +
                numberTeddyBreaks + numberMinions + numberTrucks;

            double profit = 0;
            if (numberToys >= 50)
            {
                double discount = totalSum * 0.25;
                totalSum -= discount;            
            }

            double rent = totalSum * 0.10;
            profit = totalSum - rent;

            if (profit >=priceOfExcursion)
            {
                Console.WriteLine($"Yes! {profit - priceOfExcursion:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfExcursion - profit:f2} lv needed.");
            }
        }
    }
}
