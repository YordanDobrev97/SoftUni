using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SantaList
{
    class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine()
                .Split('&').ToList();

            string line = Console.ReadLine();

            while (line != "Finished!")
            {
                string[] argumentas = line.Split(" ");
                string name = argumentas[1];
                switch (argumentas[0])
                {
                    case "Bad":
                        if (!list.Contains(name))
                        {
                            list.Insert(0, name);
                        }
                        break;
                    case "Good":
                        if (list.Contains(name))
                        {
                            list.Remove(name);
                        }
                        break;
                    case "Rename":
                        string oldName = name;
                        string newName = argumentas[2];

                        if (list.Contains(oldName))
                        {
                            int indexOldName = list.IndexOf(oldName);
                            list[indexOldName] = newName;
                        }
                        break;
                    case "Rearrange":
                        if (list.Contains(name))
                        {
                            list.Remove(name);
                            list.Add(name);
                        }
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
