using System;

namespace _01.SpringVacationTrip
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int countPeople = int.Parse(Console.ReadLine());
            double priceFuelPerKm = double.Parse(Console.ReadLine());
            double priceFood = double.Parse(Console.ReadLine());
            double priceHotel = double.Parse(Console.ReadLine());

            double cost = 0;
            double foodPrice = priceFood * countPeople * days;
            double hotelPrice = priceHotel * countPeople * days;

            if (countPeople > 10)
            {
                hotelPrice -= hotelPrice * 0.25;
            }

            double totalPrice = foodPrice + hotelPrice;

            for (int day = 1; day <=days; day++)
            {
                double distance = double.Parse(Console.ReadLine());

                double currentFuelKm = distance * priceFuelPerKm;
                totalPrice += currentFuelKm;

                if (day % 3 == 0 || day % 5 == 0)
                {
                    totalPrice += totalPrice * 0.40;
                }

                if (day % 7 == 0)
                {
                    totalPrice -= totalPrice / countPeople;
                }
                cost = totalPrice;
            }

            if (cost <= budget)
            {
                Console.WriteLine($"You have reached the destination. You have {budget - cost:f2}$ budget left.");
            }
            else
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {cost - budget:f2}$ more.");
            }
        }
    }
}
