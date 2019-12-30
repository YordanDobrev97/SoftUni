using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            var contestUsers = new Dictionary<string, Dictionary<string, int>>();
            var statisticUser = new Dictionary<string, int>();
            while (line != "no more time")
            {
                string[] items = line.Split(" -> ");
                string name = items[0];
                string contest = items[1];
                int points = int.Parse(items[2]);

                if (!contestUsers.ContainsKey(contest))
                {
                    contestUsers.Add(contest, new Dictionary<string, int>());
                }

                if (!contestUsers[contest].ContainsKey(name))
                {
                    contestUsers[contest].Add(name, points);
                }
                else
                {
                    if (contestUsers[contest][name] < points)
                    {
                        contestUsers[contest][name] = points;
                    }
                }

                if (!statisticUser.ContainsKey(name))
                {
                    statisticUser.Add(name, points);
                }
                else
                {
                    statisticUser[name] += points; 
                }

                line = Console.ReadLine();
            }

            foreach (var item in contestUsers)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                int count = 1;

                foreach (var userPoints in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{count}. {userPoints.Key} <::> {userPoints.Value}");
                    count++;
                }
            }

            Console.WriteLine("Individual standings:");
            int countStatistic = 1;
            foreach (var item in statisticUser.OrderByDescending(x => x.Value)
                .ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{countStatistic}. {item.Key} -> {item.Value}");
                countStatistic++;
            }
        }
    }
}
