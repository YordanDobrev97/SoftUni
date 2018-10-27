using System;

namespace _05.Fan_Shop
{
    class Program
    {
        static void Main()
        {
            double hoodiePrice = 30;
            double keychainPrice = 4;
            double tShirtPrice = 20;
            double flagPrice = 15;
            double stickerPrice = 1;

            int budget = int.Parse(Console.ReadLine());
            int subjects = int.Parse(Console.ReadLine());

            double total = 0;
            for (int i = 0; i < subjects; i++)
            {
                string subject = Console.ReadLine();

                switch (subject)
                {
                    case "hoodie":
                        total += hoodiePrice;
                        break;
                    case "keychain":
                        total += keychainPrice;
                        break;
                    case "T-shirt":
                        total += tShirtPrice;
                        break;
                    case "flag":
                        total += flagPrice;
                        break;
                    case "sticker":
                        total += stickerPrice;
                        break;
                }
            }

            if (total <= budget)
            {
                Console.WriteLine("You bought {0} items and left with {1} lv.", subjects, budget - total);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0} more lv.", total - budget);
            }
        }
    }
}
