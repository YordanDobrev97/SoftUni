using System;

namespace _02.Calorie_Calculator
{
    class Program
    {
        static void Main()
        {
            char gender = char.Parse(Console.ReadLine());
            double weightInKillos = double.Parse(Console.ReadLine());
            double heigthInMeters = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string activity = Console.ReadLine();

            double bnm = 0;

            if (gender == 'm')
            {
                bnm = 66 + (13.7 * weightInKillos) + (5 * (heigthInMeters / 0.010000)) - (6.8 * age);
            }
            else
            {
                bnm = 655 + (9.6 * weightInKillos) + (1.8 * (heigthInMeters / 0.010000)) - (4.7 * age);
            }

            double koeficent = 0;
            switch (activity)
            {
                case "sedentary":
                    koeficent = 1.2;
                    break;
                case "lightly active":
                    koeficent = 1.375;
                    break;
                case "moderately active":
                    koeficent = 1.55;
                    break;
                case "very active":
                    koeficent = 1.725;
                    break;
            }

            bnm = bnm * koeficent;
            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(bnm)} calories per day.");
        }
    }
}
