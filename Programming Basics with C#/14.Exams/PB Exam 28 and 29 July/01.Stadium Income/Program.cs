using System;

namespace _01.Stadium_Income
{
    class Program
    {
        static void Main()
        {
            int numberSectors = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());

            double income = (capacity * priceTicket) / numberSectors;
            double totalIncome = income * numberSectors;
            double moneyForCharity = (totalIncome - (income * 0.75)) / 8.0;

            Console.WriteLine("Total income - {0:f2} BGN", totalIncome);
            Console.WriteLine("Money for charity - {0:f2} BGN",moneyForCharity);

        }
    }
}
