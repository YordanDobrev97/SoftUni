using System;

namespace _01.Cat_Diet
{
    class Program
    {
        static void Main()
        {
            int percentageOfFat = int.Parse(Console.ReadLine());
            int percenageOfProteins = int.Parse(Console.ReadLine());
            int percenageOfCarbohydrates = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int percenageWater = int.Parse(Console.ReadLine());

            double totalGramsFat = (percentageOfFat / 100.0) * totalCalories / 9;
            double totalGramsProteins = (percenageOfProteins / 100.0) * totalCalories / 4;
            double totalGramsCarbohydrates = (percenageOfCarbohydrates / 100.0) * totalCalories / 4;

            double weightFood = totalGramsFat + totalGramsProteins + totalGramsCarbohydrates;
            double caloriesForGramFood = totalCalories / weightFood;

            double profit = caloriesForGramFood * (1 - (percenageWater / 100.0));
            Console.WriteLine($"{profit:f4}");

        }
    }
}
