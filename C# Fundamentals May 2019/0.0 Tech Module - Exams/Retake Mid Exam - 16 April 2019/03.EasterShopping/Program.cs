using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.EasterShopping
{
    class Program
    {
        static bool IsValidIndex(int index, List<string> list)
        {
            return index >= 0 && index < list.Count;
        }

        static void Main()
        {
            var shops = Console.ReadLine()
                .Split()
                .ToList();

            int numberCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCommand; i++)
            {
                var command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Include":
                        shops.Add(command[1]);
                        break;
                    case "Visit":
                        int countRemove = int.Parse(command[2]);

                        if (command[1] == "first")
                        {
                            if (countRemove <=shops.Count)
                            {
                                shops.RemoveRange(0, countRemove);
                            }
                        }
                        else if (command[1] == "last")
                        {
                            if (countRemove <=shops.Count)
                            {
                                shops.RemoveRange(shops.Count - countRemove, countRemove);
                            }
                        }
                        break;
                    case "Prefer":
                        int firstIndex = int.Parse(command[1]);
                        int secondIndex = int.Parse(command[2]);

                        if (IsValidIndex(firstIndex, shops) 
                            && IsValidIndex(secondIndex, shops))
                        {
                            Swap(firstIndex, secondIndex, shops);
                        }
                        
                        break;
                    case "Place":
                        int insertIndex = int.Parse(command[2]);

                        if (IsValidIndex(insertIndex, shops))
                        {
                            shops.Insert(insertIndex + 1 , command[1]);
                        }
                        break;
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }

        private static void Swap(int firstIndex, int secondIndex, List<string> shops)
        {
            var temp = shops[firstIndex];
            shops[firstIndex] = shops[secondIndex];
            shops[secondIndex] = temp;
        }
    }
}
