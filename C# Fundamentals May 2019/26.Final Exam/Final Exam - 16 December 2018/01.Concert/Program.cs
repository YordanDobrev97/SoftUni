using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Concert
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            Dictionary<string, int> bandAndTime = new Dictionary<string, int>();
            Dictionary<string, List<string>> bandAndMembers = new Dictionary<string, List<string>>();

            int totalTime = 0;
            while (line != "start of concert")
            {
                string[] elements = line.Split("; ");
                string command = elements[0];
                string bandName = elements[1];

                if (command == "Add")
                {
                    List<string> members = elements[2].Split(", ").ToList();

                    if (!bandAndMembers.ContainsKey(bandName))
                    {
                        bandAndMembers.Add(bandName, new List<string>());
                    }

                    foreach (var member in members)
                    {
                        if (!bandAndMembers[bandName].Contains(member))
                        {
                            bandAndMembers[bandName].Add(member);
                        }
                    }
                }
                else if (command == "Play")
                {
                    int time = int.Parse(elements[2]);
                    totalTime += time;

                    if (!bandAndTime.ContainsKey(bandName))
                    {
                        bandAndTime.Add(bandName, 0);
                    }
                    bandAndTime[bandName] += time;
                }

                line = Console.ReadLine();
            }

            string bandNameResult = Console.ReadLine();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var item in bandAndTime.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            foreach (var item in bandAndMembers.Where(x => x.Key == bandNameResult))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var member in item.Value)
                {
                    Console.WriteLine($"=> {member}");
                }
            }

            
        }
    }
}
