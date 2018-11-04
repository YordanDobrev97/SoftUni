using System;

namespace _04.Cat_Food
{
    class Program
    {
        static void Main()
        {
            long numberCats = long.Parse(Console.ReadLine());

            long firstGroup = 0;
            long secondGroup = 0;
            long thirdGroup = 0;

            double totalFood = 0;
            for (int i = 0; i < numberCats; i++)
            {
                double gramsFood = double.Parse(Console.ReadLine());
                totalFood += gramsFood;
                if (gramsFood >= 100 && gramsFood < 200)
                {
                    firstGroup++;
                }
                else if(gramsFood >=200 && gramsFood < 300)
                {
                    secondGroup++;
                }
                else if(gramsFood >=300 && gramsFood <=400)
                {
                    thirdGroup++;
                }
            }

            Console.WriteLine($"Group 1: {firstGroup} cats.");
            Console.WriteLine($"Group 2: {secondGroup} cats.");
            Console.WriteLine($"Group 3: {thirdGroup} cats.");

            Console.WriteLine($"Price for food per day: {Math.Round((totalFood / 1000) * 12.45, 2)} lv.");
        }
    }
}
