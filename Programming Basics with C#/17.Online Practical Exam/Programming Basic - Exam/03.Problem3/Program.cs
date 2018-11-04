using System;

namespace _03.Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string durationOfContract = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string hasDessert = Console.ReadLine();
            int numberMonths = int.Parse(Console.ReadLine());

            double price = 0;
            if (durationOfContract == "one")
            {
                switch (typeContract)
                {
                    case "Small":
                        price = 9.98;
                        break;
                    case "Middle":
                        price = 18.99;
                        break;
                    case "Large":
                        price = 25.98;
                        break;
                    case "ExtraLarge":
                        price = 35.99;
                        break;
                }
            }
            else
            {
                switch (typeContract)
                {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;
                }
            }

            if (hasDessert == "yes")
            {
                if (price <=10)
                {
                    price += 5.50;
                }
                else if(price > 10 && price <= 30)
                {
                    price += 4.35;
                }
                else
                {
                    price += 3.85;
                }
            }

            double reduction = 0;
            double totalPrice = price * numberMonths;
            if (durationOfContract == "two")
            {
                totalPrice = totalPrice - (totalPrice * 0.0375);
            }

            Console.WriteLine($"{totalPrice - reduction:f2} lv.");
        }
    }
}
