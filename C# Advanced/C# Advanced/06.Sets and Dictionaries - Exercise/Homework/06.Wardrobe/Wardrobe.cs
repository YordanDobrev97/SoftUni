using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    public class Wardrobe
    {
        public static void Main()
        {
            int countLines = int.Parse(Console.ReadLine());

            var colorsClothesCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < countLines; i++)
            {
                string[] elements = Console.ReadLine().Split(" -> ");
                string color = elements[0];
                string[] clothes = elements[1].Split(",");

                if (!colorsClothesCount.ContainsKey(color))
                {
                    colorsClothesCount.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {
                    if (!colorsClothesCount[color].ContainsKey(item))
                    {
                        colorsClothesCount[color].Add(item, 0);
                    }

                    colorsClothesCount[color][item]++;
                }
            }

            string[] colorClotheFind = Console.ReadLine().Split();
            string findColor = colorClotheFind[0];
            string findGarment = colorClotheFind[1];

            foreach (var item in colorsClothesCount)
            {
                string color = item.Key;
                var clothes = item.Value;
                Console.WriteLine($"{color} clothes:");

                foreach (var garment in clothes)
                {
                    if (findColor == color && garment.Key == findGarment)
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value}");
                    }
                }
            }
        }
    }
}
