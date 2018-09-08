using System;

namespace _03.Campaign
{
    class CharityCampaign
    {
        private const int pricePerCake = 45;
        private const double pricePerWaffles = 5.80;
        private const double pricePerPancake = 3.20;

        static void Main()
        {
            int numberDaysCompany = int.Parse(Console.ReadLine());
            int numberPerConfectioner = int.Parse(Console.ReadLine());
            int numberCake = int.Parse(Console.ReadLine());
            int numberWaffles = int.Parse(Console.ReadLine());
            int numberPancake = int.Parse(Console.ReadLine());

            int cakes = numberCake * pricePerCake;
            double waffles = numberWaffles * pricePerWaffles;
            double pancakes = numberPancake * pricePerPancake;

            double totalSumPerDay = (cakes + waffles + pancakes) * numberPerConfectioner;
            double sumPerFullCompany = totalSumPerDay * numberDaysCompany;
            double sum = sumPerFullCompany - (sumPerFullCompany * 0.125);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
