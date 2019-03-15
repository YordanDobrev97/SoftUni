﻿using System;

namespace _05.Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = CalcOrder(product, quantity);
            PrintPrice(price);

        }
        static double CalcOrder(string product, int quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    break;
            }

            price = price * quantity;
            return price;
        }

        static void PrintPrice(double price)
        {
            Console.WriteLine($"{price:f2}");
        }
    }
}
