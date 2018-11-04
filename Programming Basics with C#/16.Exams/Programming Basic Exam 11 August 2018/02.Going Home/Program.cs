using System;

namespace _02.Going_Home
{
    class Program
    {
        static void Main()
        {
            double distanceInKillometers = double.Parse(Console.ReadLine());
            double gasolinePer100Killometers = double.Parse(Console.ReadLine());
            double priceOfGasoline = double.Parse(Console.ReadLine());
            double moneyFromTournament = double.Parse(Console.ReadLine());

            double costOfCar = distanceInKillometers * gasolinePer100Killometers / 100.0;
            double totalCost = costOfCar * priceOfGasoline;
            double availableMoney = totalCost - moneyFromTournament;
            double allocation = moneyFromTournament / 5.0;

            if (moneyFromTournament >= totalCost)
            {
                Console.WriteLine("You can go home. {0:f2} money left.", Math.Abs(availableMoney));
            }
            else
            {
                Console.WriteLine("Sorry, you cannot go home. Each will receive {0:f2} money.", allocation);
            }
        }
    }
}
