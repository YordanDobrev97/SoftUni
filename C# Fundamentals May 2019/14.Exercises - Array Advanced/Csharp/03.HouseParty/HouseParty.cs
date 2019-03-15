using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    public class HouseParty
    {
        public static void Main()
        {
            int numberCommand = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();
            for (int i = 0; i < numberCommand; i++)
            {
                string[] commandParams = Console.ReadLine()
                    .Split();

                string name = commandParams[0];
                if (commandParams.Length == 3)
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(name);
                    }
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
