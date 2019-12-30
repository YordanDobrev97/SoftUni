using System;

namespace Cooking_Masterclass
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            double aprons = Math.Ceiling(students + (students * 0.20));

            int countFreePackage = 0;

            for (int i = 1; i <=students; i++)
            {
                if (i % 5 == 0)
                {
                    countFreePackage++;
                }
            }

            countFreePackage = students - countFreePackage;
            double result = priceApron * aprons + priceEggs * 10 * students + priceFlour * countFreePackage;

            if (result <= budget)
            {
                Console.WriteLine($"Items purchased for {result:f2}$.");
            }
            else
            {
                Console.WriteLine($"{result - budget:f2}$ more needed.");
            }
        }
    }
}
