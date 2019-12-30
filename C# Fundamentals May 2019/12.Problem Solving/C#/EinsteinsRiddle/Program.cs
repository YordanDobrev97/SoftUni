using System;

namespace EinsteinsRiddle
{
    class Program
    {
        static string[] houses = { "Red", "Green", "Yellow", "White", "Blue"};
        static string[] pets = { "Dog", "Cat", "Bird", "Horse", "Fish" };
        static string[] nationalities = { "Brit", "Swede", "Dane", "Norwegian", "German" };
        static string[] cigarettes = { "Blend", "Prince", "Dunhill", "BlueMaster", "PullMall" };
        static string[] drinks = { "Tea", "Coffe", "Milk", "Beer", "Water" };
        static string[] hints = new string[15];

        static void Main()
        {
            Random random = new Random();
            Shuffle(random);
            GenerateHints();

            Console.WriteLine("Einstein’s Riddle");
            Console.WriteLine("The situation:");
            Console.WriteLine("     1.There are 5 house in five different colors.");
            Console.WriteLine("     2.In each house lives a person a different nationality.");
            Console.WriteLine("     3.These five owners drink a certain type of beverage, smoke a certain " +
                "brand of cigar and keep a certain pet.");
            Console.WriteLine("     4.No owners have the same pet, smoke the same brand of cigar" +
                "or drink the same beverage.");

            Console.WriteLine($"The question is: Who owns the {pets[3]}");
            Console.WriteLine("Hints:");

            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine($"{i}. {hints[i - 1]}");
            }

            while ((Console.ReadLine()) != "solution")
            {
                Console.WriteLine("Wrong solution! Try again!");
            }
        }

        static void Shuffle(Random random)
        {
            int count = 5;

            for (int i = 0; i < count; i++)
            {
                int randomHouse = random.Next(0, houses.Length - i);
                Swap(i, randomHouse, houses);

                int randomPets = random.Next(0, pets.Length - i);
                Swap(i, randomPets, pets);

                int randomNationalities = random.Next(0, nationalities.Length - i);
                Swap(i, randomNationalities, nationalities);

                int randomCigarettes = random.Next(0, cigarettes.Length - i);
                Swap(i, randomCigarettes, nationalities);

                int randomDrinks = random.Next(0, drinks.Length - i);
                Swap(i, randomDrinks, drinks);
            }
        }

        static void Swap(int from, int to, string[] data)
        {
            string temp = data[from];
            data[from] = data[to];
            data[to] = temp;
        }

        static void GenerateHints()
        {
            hints[0] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[1] = $"the {nationalities[4]} keeps {pets[4]} as pets";
            hints[2] = $"the {nationalities[1]} drinks {drinks[1]}";
            hints[3] = $"the {houses[3]} house is on the left of the {houses[4]} house";
            hints[4] = $"the {houses[3]} house's owner drinks {drinks[3]}";
        }
    }
}
