using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    public class Program
    {
        public static void Main()
        {
            int currentShards = 0;
            int currentFragments = 0;
            int currentMotes = 0;

            int maxQuantity = 250;
            int maxShard = maxQuantity;
            int maxFragments = maxQuantity;
            int maxMotes = maxQuantity;

            string winner = string.Empty;

            var materials = new Dictionary<string, int>();
            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;

            var junks = new Dictionary<string, int>();
            while (true)
            {
                var elements = Console.ReadLine().Split(" ");
                bool isEnd = false;
                for (int i = 0; i < elements.Length; i += 2)
                {
                    var quantity = int.Parse(elements[i]);
                    var item = elements[i + 1].ToLower();

                    switch (item)
                    {
                        case "shards":
                            currentShards += quantity;
                            if (!materials.ContainsKey(item))
                            {
                                materials.Add(item, 0);
                            }
                            materials[item] += quantity;
                            break;
                        case "fragments":
                            currentFragments += quantity;
                            if (!materials.ContainsKey(item))
                            {
                                materials.Add(item, 0);
                            }
                            materials[item] += quantity;
                            break;
                        case "motes":
                            currentMotes += quantity;
                            if (!materials.ContainsKey(item))
                            {
                                materials.Add(item, 0);
                            }
                            materials[item] += quantity;
                            break;
                        default:
                            if (!junks.ContainsKey(item))
                            {
                                junks[item] = 0;
                            }
                            junks[item] += quantity;
                            break;
                    }


                    if (currentShards >= maxShard)
                    {
                        winner = "Shadowmourne";
                        materials["shards"] -= maxShard;
                        isEnd = true;
                        break;
                    }
                    else if (currentFragments >= maxFragments)
                    {
                        winner = "Valanyr";
                        materials["fragments"] -= maxFragments;
                        isEnd = true;
                        break;
                    }
                    else if (currentMotes >= maxMotes)
                    {
                        winner = "Dragonwrath";
                        materials["motes"] -= maxMotes;
                        isEnd = true;
                        break;
                    }
                }

                if (isEnd)
                {
                    break;
                }
            }

            Console.WriteLine($"{winner} obtained!");

            foreach (var material in materials.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string key = material.Key;
                int value = material.Value;
                Console.WriteLine($"{key}: {value}");
            }

            foreach (var item in junks.OrderBy(x => x.Key))
            {
                string key = item.Key;
                int value = item.Value;
                Console.WriteLine($"{key}: {value}");
            }
        }
    }
}