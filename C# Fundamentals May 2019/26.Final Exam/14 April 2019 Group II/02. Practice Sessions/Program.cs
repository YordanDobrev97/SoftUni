using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Practice_Sessions
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> roadRacers = new Dictionary<string, List<string>>();
            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] elements = line.Split("->");

                string command = elements[0];
                string road = elements[1];

                if (command == "Add")
                {
                    string racer = elements[2];
                    if (!roadRacers.ContainsKey(road))
                    {
                        roadRacers.Add(road, new List<string>());
                    }

                    roadRacers[road].Add(racer);
                }
                else if (command == "Move")
                {
                    string currentRoad = elements[1];
                    string racer = elements[2];
                    string newRoad = elements[3];

                    var racers = roadRacers[currentRoad];
                    if (racers.Contains(racer))
                    {
                        racers.Remove(racer);

                        roadRacers[newRoad].Add(racer);
                    }
                }
                else if  (command == "Close")
                {
                    if (roadRacers.ContainsKey(road))
                    {
                        roadRacers.Remove(road);
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("Practice sessions:");
            foreach (var item in roadRacers.OrderByDescending(x => x.Value.Count).
                ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var racer in item.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
