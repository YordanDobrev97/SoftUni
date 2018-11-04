using System;

namespace _02.Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGuest = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceCouvert = numberGuest * 20;

            if (priceCouvert < budget)
            {
                double residue = budget - priceCouvert;
                double moneyForFireworks = residue * 0.40;
                double moneyForDonation = residue - moneyForFireworks;
                Console.WriteLine($"Yes! {Math.Round(moneyForFireworks,0)} lv are for fireworks and {Math.Round(moneyForDonation,0)} lv are for donation.");
            }
            else
            {
               Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(priceCouvert- budget,0)} lv more.");
            }
        }
    }
}
