using System;

namespace _13.Match_Tickets
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberPersonGroup = int.Parse(Console.ReadLine());

            double priceCategory = 0;
            if (category == "VIP")
            {
                priceCategory = 499.99;
            }
            else
            {
                priceCategory = 249.99;
            }

            double percentFromBudget = 0;

            if (numberPersonGroup >= 1 && numberPersonGroup <= 4)
            {
                percentFromBudget = budget * 0.75;
            }
            else if(numberPersonGroup >= 5 && numberPersonGroup <= 9)
            {
                percentFromBudget = budget * 0.60;
            }
            else if(numberPersonGroup >= 10 && numberPersonGroup <= 24)
            {
                percentFromBudget = budget * 0.50;
            }
            else if(numberPersonGroup >= 25 && numberPersonGroup <= 49)
            {
                percentFromBudget = budget * 0.40;
            }
            else
            {
                percentFromBudget = budget * 0.25;
            }

            double price = priceCategory * numberPersonGroup;
            double remainder = budget - percentFromBudget;

            if (price <=remainder)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", remainder - price);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", price  - remainder);
            }
        }
    }
}
