using System;

namespace _01.PC_Store
{
    class Program
    {
        static void Main()
        {
            double priceCPU = double.Parse(Console.ReadLine());
            double priceVideoCard = double.Parse(Console.ReadLine());
            double priceRam = double.Parse(Console.ReadLine());
            int numbersRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            priceCPU *= 1.57;
            priceVideoCard *= 1.57;
            priceRam *= 1.57;

            double totalPriceRam = priceRam * numbersRam;
            double priceCpuAfterDiscount = priceCPU - (priceCPU * discount);
            double priceVideoCardAfterDiscount = priceVideoCard - (priceVideoCard * discount);

            double totalPrice = totalPriceRam + priceCpuAfterDiscount + priceVideoCardAfterDiscount;

            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");
        }
    }
}
