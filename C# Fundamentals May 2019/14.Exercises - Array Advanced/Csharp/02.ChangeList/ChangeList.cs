using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.ChangeList
{
    public class ChangeList
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] command = commands.Split();
                int element = int.Parse(command[1]);

                switch (command[0])
                {
                    case "Delete":
                        numbers.RemoveAll(x => x == element);
                        break;
                    case "Insert":
                        int position = int.Parse(command[2]);
                        numbers.Insert(position, element);
                        break;
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
