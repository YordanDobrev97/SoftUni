using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OnWayAnnapurna
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();

            var storeWithItems = new Dictionary<string, List<string>>();

            while (line != "END")
            {
                var elements = line.Split("->");

                var command = elements[0];
                var store = elements[1];
                switch (command)
                {
                    case "Add":
                        var items = elements[2].Split(",");

                        if (!storeWithItems.ContainsKey(store))
                        {
                            storeWithItems.Add(store, new List<string>());
                        }
                        storeWithItems[store].AddRange(items);
                        break;
                    case "Remove":
                        if (storeWithItems.ContainsKey(store))
                        {
                            storeWithItems.Remove(store);
                        }
                        break;
                }

                line = Console.ReadLine();
            }

            storeWithItems = storeWithItems.OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Stores list:");
            foreach (var item in storeWithItems)
            {
                Console.WriteLine(item.Key);

                foreach (var values in item.Value)
                {
                    Console.WriteLine($"<<{values}>>");
                }
            }
        }
    }
}
