using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem3
{
    class Area
    {
        public List<string> Names { get; set; } = new List<string>();

        public int CountHungryAnimals { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            Dictionary<string, int> animals = new Dictionary<string, int>();
            var hungryAnimals = new Dictionary<string, Area>();
            while (line != "Last Info")
            {
                string[] elements = line.Split(":");

                if (elements[0] == "Add")
                {
                    if (!hungryAnimals.ContainsKey(elements[3]))
                    {
                        hungryAnimals.Add(elements[3], new Area());
                        hungryAnimals[elements[3]].Names.Add(elements[1]);
                        hungryAnimals[elements[3]].CountHungryAnimals++;
                    }

                    if (!hungryAnimals[elements[3]].Names.Contains(elements[1]))
                    {
                        hungryAnimals[elements[3]].CountHungryAnimals++;
                        hungryAnimals[elements[3]].Names.Add(elements[1]);
                    }
                    
                    if (!animals.ContainsKey(elements[1]))
                    {
                        animals.Add(elements[1], int.Parse(elements[2]));
                    }
                    else
                    {
                        animals[elements[1]] += int.Parse(elements[2]);
                    }
                }
                else if (elements[0] == "Feed")
                {
                    if (!animals.ContainsKey(elements[1]))
                    {
                        line = Console.ReadLine();
                        continue;
                    }

                    animals[elements[1]] -= int.Parse(elements[2]);

                    if (animals[elements[1]] <= 0)
                    {
                        Console.WriteLine($"{elements[1]} was successfully fed");
                        animals.Remove(elements[1]);
                        hungryAnimals.Remove(elements[3]); // from list remove
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("Animals:");

            foreach (var item in animals.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");

            foreach (var item in hungryAnimals.OrderByDescending(x => x.Value.CountHungryAnimals))
            {
                Console.WriteLine($"{item.Key} : {item.Value.CountHungryAnimals}");
            }
        }
    }
}
