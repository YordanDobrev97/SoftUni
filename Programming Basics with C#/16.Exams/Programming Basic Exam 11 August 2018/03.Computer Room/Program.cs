using System;

namespace _03.Computer_Room
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int numberHours = int.Parse(Console.ReadLine());
            int numberGroup = int.Parse(Console.ReadLine());
            string timeDay = Console.ReadLine();

            double price = 0;
            switch (month)
            {
                case "march":
                case "april":
                case "may":

                    switch (timeDay)
                    {
                        case "day":
                            price = 10.50;
                            break;
                        case "night":
                            price = 8.40;
                            break;
                    }

                    break;
                case "june":
                case "july":
                case "august":

                    switch (timeDay)
                    {
                        case "day":
                            price = 12.60;
                            break;
                        case "night":
                            price = 10.20;
                            break;
                    }
                    break;
            }

            if (numberGroup >=4)
            {
                price = price - (price * 0.10);
            }

            if (numberHours >= 5)
            {
                price = price - (price * 0.50);
            }

            Console.WriteLine("Price per person for one hour: {0:f2}", price);
            price = price * numberHours * numberGroup;
            Console.WriteLine("Total cost of the visit: {0:f2}", price);
        }
    }
}
