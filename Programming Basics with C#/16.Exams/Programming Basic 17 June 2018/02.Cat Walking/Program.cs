using System;

namespace _02.Cat_Walking
{
    class Program
    {
        static void Main()
        {
            int minuteWalkDay = int.Parse(Console.ReadLine());
            int numberOfWalksPerDay = int.Parse(Console.ReadLine());
            int catCaloriesPerDay = int.Parse(Console.ReadLine());

            int totalMinutesWalks = minuteWalkDay * numberOfWalksPerDay;
            int burnedCalories = totalMinutesWalks * 5;
            double caloriesPerDay = catCaloriesPerDay * 0.50;

            if (burnedCalories >=caloriesPerDay)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
