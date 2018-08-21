using System;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = -1;

            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (product == "banana")
                {
                    price = 2.70;
                }
                else if(product == "apple")
                {
                    price = 1.25;
                }
                else if(product == "orange")
                {
                    price = 0.90;
                }
                else if(product == "grapefruit")
                {
                    price = 1.60;
                }
                else if(product == "kiwi")
                {
                    price = 3.00;
                }
                else if(product == "pineapple")
                {
                    price = 5.60;
                }
                else if(product == "grapes")
                {
                    price = 4.20;
                }
            }
            else if(dayOfWeek == "Monday"    ||
                    dayOfWeek == "Tuesday"   ||
                    dayOfWeek == "Wednesday" ||
                    dayOfWeek == "Thursday"  ||
                    dayOfWeek == "Friday")
            {
                if (product == "banana")
                {
                    price = 2.50;
                }
                else if (product == "apple")
                {
                    price = 1.20;
                }
                else if (product == "orange")
                {
                    price = 0.85;
                }
                else if (product == "grapefruit")
                {
                    price = 1.45;
                }
                else if (product == "kiwi")
                {
                    price = 2.70;
                }
                else if (product == "pineapple")
                {
                    price = 5.50;
                }
                else if (product == "grapes")
                {
                    price = 3.85;
                }
            }

            if (price == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{quantity * price:f2}");
            }
        }
    }
}
