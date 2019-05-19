using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudent = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0.0;

            if (dayOfWeek == "Friday")
            {
                if (typeGroup == "Students")
                {
                    price = 8.45;
                }
                else if(typeGroup == "Business")
                {
                    price = 10.90;
                }
                else if(typeGroup == "Regular")
                {
                    price = 15;
                }
            }
            else if(dayOfWeek == "Saturday")
            {
                if (typeGroup == "Students")
                {
                    price = 9.80;
                }
                else if (typeGroup == "Business")
                {
                    price = 15.60;
                }
                else if (typeGroup == "Regular")
                {
                    price = 20;
                }
            }
            else if(dayOfWeek == "Sunday")
            {
                if (typeGroup == "Students")
                {
                    price = 10.46;
                }
                else if (typeGroup == "Business")
                {
                    price = 16;
                }
                else if (typeGroup == "Regular")
                {
                    price = 22.50;
                }
            }

            price *= numberStudent;

            if (numberStudent >= 30 && typeGroup == "Students")
            {
                price = price - (price * 0.15);
            }
            else if (numberStudent >= 10 && numberStudent <= 20 && typeGroup == "Regular")
            {
                price = price - (price * 0.05);
            }
            else if(numberStudent >= 100 && typeGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = price - 10 * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = price - 10 * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = price - 10 * 16;
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
