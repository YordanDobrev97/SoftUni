using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    public class Program
    {
        private const int MAX_VALUE = 255;
        private const int MAX_MOTES = MAX_VALUE;
        private const int MAX_FRAGMENTS = MAX_VALUE;
        private const int MAX_SHARDS = MAX_VALUE;

        public static void Main()
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(' ');

            var materials = new Dictionary<string, int>();

            int currentMotes = 0;
            int currentFragments = 0;
            int currentShards = 0;

            int currentQuantity = 0;
            
            string nameWin = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int quantity = int.Parse(input[i]);
                    currentQuantity = quantity;
                }
                else
                {
                    string material = input[i];

                    switch (material)
                    {
                        case "motes":
                            currentMotes += currentQuantity;

                            if (currentMotes == MAX_MOTES)
                            {
                                nameWin = "Dragonwrath";
                                AddMaterial(material, materials, currentMotes);
                                break;
                            }
                            else if (currentMotes > MAX_MOTES)
                            {
                                currentMotes -= MAX_MOTES;
                                AddMaterial(material, materials, currentMotes);

                                if (HasWin(materials))
                                {
                                    nameWin = "Dragonwrath";
                                    break;
                                }
                                break;
                            }
                            AddMaterial(material, materials, currentQuantity);
                            break;
                        case "fragments":
                            currentFragments += currentQuantity;

                            if (currentFragments == MAX_FRAGMENTS)
                            {
                                nameWin = "Valanyr";
                                AddMaterial(material, materials, currentQuantity);
                                break;
                            }
                            else if(currentFragments > MAX_FRAGMENTS)
                            {
                                currentFragments -= currentQuantity;
                                AddMaterial(material, materials, currentFragments);

                                if (HasWin(materials))
                                {
                                    nameWin = "Valanyr";
                                    break;
                                }
                            }

                            AddMaterial(material, materials, currentQuantity);
                            break;
                        case "shards":
                            currentShards += currentQuantity;
                            if (currentShards == MAX_SHARDS)
                            {
                                nameWin = "Shadowmourne";
                                AddMaterial(material, materials, currentQuantity);
                                break;
                            }
                            else if(currentShards > MAX_SHARDS)
                            {
                                currentShards -= MAX_SHARDS;
                                AddMaterial(material, materials, currentShards);

                                if (HasWin(materials))
                                {
                                    nameWin = "Shadowmourne";
                                    break;
                                }
                                break;
                            }
                            AddMaterial(material, materials, currentQuantity);
                            break;
                        default:
                            AddMaterial(material, materials, currentQuantity);
                            break;
                    }

                    if (HasWin(materials))
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"{nameWin} obtained!");
            foreach (var item in materials)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }

        private static bool HasWin(Dictionary<string, int> materials)
        {
            return materials.ContainsValue(MAX_VALUE);
        }

        private static void AddMaterial(string material, Dictionary<string, int> materials, int currentMotes)
        {
            if (!materials.ContainsKey(material))
            {
                materials.Add(material, currentMotes);
            }
            else
            {
                materials[material] += currentMotes;
            }
        }
    }
}
