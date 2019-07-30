using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.On_the_WayAnnapurna
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            Dictionary<string, List<string>> storeItems = new Dictionary<string, List<string>>();

            while (line != "END")
            {
                string[] elements = line.Split("->");

                string command = elements[0];
                string store = elements[1];

                if (command == "Add")
                {
                    List<string> items = elements[2].Split(",").ToList();
                    if (!storeItems.ContainsKey(store))
                    {
                        storeItems.Add(store, new List<string>());
                    }

                    storeItems[store].AddRange(items);
                }
                else if (command == "Remove")
                {
                    if (storeItems.ContainsKey(store))
                    {
                        storeItems.Remove(store);
                    }
                }
                
                line = Console.ReadLine();
            }

            Console.WriteLine("Stores list:");
            foreach (var item in storeItems.OrderByDescending(x => x.Value.Count).
                ThenByDescending(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var value in item.Value)
                {
                    Console.WriteLine($"<<{value}>>");
                }
            }
        }
    }
}
