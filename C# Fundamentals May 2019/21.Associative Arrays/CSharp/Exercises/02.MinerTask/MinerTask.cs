using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MinerTask
{
    public class MinerTask
    {
        public static void Main()
        {
            var resources = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            int row = 1;
            string lastResource = string.Empty;

            while (input != "stop")
            {
                if (row % 2 == 1)
                {
                    string resource = input;
                    lastResource = resource;
                    if (!resources.ContainsKey(resource))
                    {
                        resources.Add(resource, new List<int>());
                    }
                }
                else
                {
                    resources[lastResource].Add(int.Parse(input));
                }

                row++;

                input = Console.ReadLine();
            }

            PrintResources(resources);
        }

        private static void PrintResources(Dictionary<string, List<int>> resources)
        {
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Sum()}");
            }
        }
    }
}
