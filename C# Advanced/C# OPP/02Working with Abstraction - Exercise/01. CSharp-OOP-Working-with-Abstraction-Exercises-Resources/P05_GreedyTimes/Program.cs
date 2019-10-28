using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long stones = 0;
            long money = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long count = long.Parse(safe[i + 1]);

                string result = string.Empty;

                if (name.Length == 3)
                {
                    result = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    result = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    result = "Gold";
                }

                if (result == "" || input < bag.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (result)
                {
                    case "Gem":
                        if (!bag.ContainsKey(result))
                        {
                            if (!bag.ContainsKey("Gold") || count > bag["Gold"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else if (bag[result].Values.Sum() + count > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(result))
                        {
                            if (!bag.ContainsKey("Gem") || count > bag["Gem"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else if (bag[result].Values.Sum() + count > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(result))
                {
                    bag[result] = new Dictionary<string, long>();
                }

                if (!bag[result].ContainsKey(name))
                {
                    bag[result][name] = 0;
                }

                bag[result][name] += count;
                if (result == "Gold")
                {
                    gold += count;
                }
                else if (result == "Gem")
                {
                    stones += count;
                }
                else if (result == "Cash")
                {
                    money += count;
                }
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}