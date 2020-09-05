using System;
using System.Collections.Generic;
using WildFarm.Enums;
using WildFarm.Models.Animal;
using WildFarm.Models.Foods;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string line = Console.ReadLine();
                string[] elementsAnimal = line.Split();

                if (line == "End")
                {
                    break;
                }

                string[] elementsFood = Console.ReadLine().Split();
                AnimalFactory factory = new AnimalFactory();
                Animal animal = factory.Create(elementsAnimal[0], elementsAnimal);
                Console.WriteLine(animal.ProducingSound());

                FoodFactory foodFactory = new FoodFactory();
                Food food = foodFactory.Create(elementsFood[0], elementsFood);

                try
                {
                    animal.Food(food);
                    animal.IncreasWeight(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
