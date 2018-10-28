using System;
class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        double moneyForSouvenirs = double.Parse(Console.ReadLine());
        double moneyForHotel = double.Parse(Console.ReadLine());

        double littersGas = 420.0 / 100 * 7;
        double gas = littersGas * 1.85;

        double moneyForFoodSouvenirs = 3 * money + 3 * moneyForSouvenirs;

        double firstDayDiscount = moneyForHotel - (moneyForHotel * 0.10);
        double secondDayDiscount = moneyForHotel - (moneyForHotel * 0.15);
        double thirdDayDiscount = moneyForHotel - (moneyForHotel * 0.20);

        double totalSum = gas + moneyForFoodSouvenirs + firstDayDiscount + secondDayDiscount + thirdDayDiscount;

        Console.WriteLine($"Money needed: {totalSum:f2}");
    }
}

