using System;

namespace _06.Cat_Shelter
{
    class Program
    {
        static void Main()
        {
            int killosFood = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            int maxKillos = killosFood * 1000;
            int totalFood = 0;
            while (line != "Adopted")
            {
                int grams = int.Parse(line);
                totalFood += grams;

                line = Console.ReadLine();
            }

            if (totalFood <=maxKillos)
            {
                Console.WriteLine($"Food is enough! Leftovers: {maxKillos - totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFood - maxKillos} grams more.");
            }
        }
    }
}
