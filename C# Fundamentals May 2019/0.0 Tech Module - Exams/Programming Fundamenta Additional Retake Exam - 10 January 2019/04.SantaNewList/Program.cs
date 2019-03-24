using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SantaNewList
{
    class Program
    {
        static void Main()
        {
            var goodChildren = new Dictionary<string, int>();
            var toys = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] paramsInput = input.Split("->");
                if (paramsInput[0] == "Remove")
                {
                    goodChildren.Remove(paramsInput[1]);
                }
                else
                {
                    string children = paramsInput[0];
                    string toy = paramsInput[1];
                    int amount = int.Parse(paramsInput[2]);

                    if (!goodChildren.ContainsKey(children))
                    {
                        goodChildren.Add(children, amount);
                    }
                    else
                    {
                        goodChildren[children] += amount;
                    }

                    if (!toys.ContainsKey(toy))
                    {
                        toys.Add(toy, amount);
                    }
                    else
                    {
                        toys[toy] += amount;
                    }
                }

                input = Console.ReadLine();
            }

            goodChildren = goodChildren.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);

            Console.WriteLine("Children:");

            foreach (var child in goodChildren)
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }

            Console.WriteLine($"Presents:");
            foreach (var toy in toys)
            {
                Console.WriteLine($"{toy.Key} -> {toy.Value}");
            }
        }
    }
}
