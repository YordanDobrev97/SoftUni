﻿using System;

namespace _07.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            double price = 0;
            bool hasError = false;
            if (typeOfDay == "Weekday")
            {
                if (age >=0 && age <= 18)
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
                else if(age > 64 && age <= 122)
                {
                    price = 12;
                }
                else
                {
                    hasError = true;
                }
            }
            else if(typeOfDay == "Weekend")
            {
                if (age >=0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
                else
                {
                    hasError = true;
                }
            }
            else
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                else
                {
                    hasError = true;
                }
            }

            if (hasError)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
