using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Party!")
                {
                    break;
                }

                string[] elements = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = elements[0];
                string direction = elements[1];
                string criteria = elements[2];

                Func<string, bool> startWith = (x) => x.StartsWith(criteria);
                Func<string, bool> endWith = (x) => x.EndsWith(criteria);
                switch (command)
                {
                    case "Remove":
                        Action<List<string>> remove = items =>
                        {
                            if (direction == "StartsWith")
                            {
                                var filterStartWith = names.Where(startWith).ToList();
                                Action<List<string>> itemsForRemove = collection =>
                                {
                                    for (int i = 0; i < filterStartWith.Count; i++)
                                    {
                                        names.Remove(filterStartWith[i]);
                                    }
                                };
                                itemsForRemove(filterStartWith);
                            }
                            else if (direction == "EndsWith")
                            {
                                var filterEndWith = names.Where(endWith).ToList();
                                Action<List<string>> itemsForRemove = collection =>
                                {
                                    for (int i = 0; i < filterEndWith.Count; i++)
                                    {
                                        names.Remove(filterEndWith[i]);
                                    }
                                };
                                itemsForRemove(filterEndWith);
                            }
                            else if (direction == "Length")
                            {
                                Func<string, bool> equalLength = (x) => x.Length == int.Parse(criteria);
                                var filterLength = names.Where(equalLength).ToList();
                                Action<List<string>> itemsForRemove = collection =>
                                {
                                    for (int i = 0; i < filterLength.Count; i++)
                                    {
                                        names.Remove(filterLength[i]);
                                    }
                                };
                                itemsForRemove(filterLength);
                            }
                        };
                        remove(names);
                        break;
                    case "Double":
                        Action<List<string>> doublePersons = items =>
                        {
                            if (direction == "StartsWith")
                            {
                                var filterStartWith = names.Where(startWith).ToList();
                                names.InsertRange(0, filterStartWith);
                            }
                            else if (direction == "EndsWith")
                            {
                                var filterEndWith = names.Where(endWith).ToList();
                                names.InsertRange(0,filterEndWith);
                            }
                            else if (direction == "Length")
                            {
                                Func<string, bool> equalLength = (x) => x.Length == int.Parse(criteria);
                                var filterLength = names.Where(equalLength).ToList();
                                names.InsertRange(0, filterLength);
                            }
                        };
                        doublePersons(names);
                        break;
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", names.OrderBy(x => x))} are going to the party!");
            }
        }
    }
}
