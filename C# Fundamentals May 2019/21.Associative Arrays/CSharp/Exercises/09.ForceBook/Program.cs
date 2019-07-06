using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            var sideUsers = new Dictionary<string, List<string>>();
            while (line != "Lumpawaroo")
            {
                if (line.Contains("|"))
                {
                    var items = line.Split(" | ");

                    var currentUser = items[1];
                    var side = items[0];

                    if (!sideUsers.ContainsKey(side))
                    {
                        sideUsers.Add(side, new List<string>());
                    }

                    if (!sideUsers[side].Contains(currentUser))
                    {
                        sideUsers[side].Add(currentUser);
                    }
                }
                else
                {
                    var items = line.Split(" -> ");
                    var currentUser = items[0];
                    var side = items[1];

                    var isContainsUser = false;
                    var key = string.Empty;

                    foreach (var item in sideUsers)
                    {
                        if (item.Value.Contains(currentUser))
                        {
                            key = item.Key;
                            isContainsUser = true;
                            break;
                        }
                    }

                    Console.WriteLine($"{currentUser} joins the {side} side!");
                    if (isContainsUser)
                    {
                        sideUsers[key].Remove(currentUser);
                        if (sideUsers.ContainsKey(side))
                        {
                            sideUsers[side].Add(currentUser);
                        }
                        else
                        {
                            if (!sideUsers.ContainsKey(side))
                            {
                                sideUsers.Add(side, new List<string>());
                            }

                            if (!sideUsers[side].Contains(currentUser))
                            {
                                sideUsers[side].Add(currentUser);
                            }
                        }
                    }
                    else
                    {
                        if (!sideUsers.ContainsKey(side))
                        {
                            sideUsers.Add(side, new List<string>());
                        }

                        if (!sideUsers[side].Contains(currentUser))
                        {
                            sideUsers[side].Add(currentUser);
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var item in sideUsers.Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                var users = item.Value;
                users.Sort();
                foreach (var user in users)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
