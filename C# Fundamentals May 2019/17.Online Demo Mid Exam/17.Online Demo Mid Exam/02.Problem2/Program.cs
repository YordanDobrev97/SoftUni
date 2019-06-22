using System;
using System.Linq;

namespace _02.Problem2
{
    class Program
    {
        static void Main()
        {
            var gifts = Console.ReadLine()
                .Split()
                .ToList();

            string line = Console.ReadLine();

            while (line != "No Money")
            {
                string[] elements = line.Split();
                string command = elements[0];
                string gift = elements[1];

                switch (command)
                {
                    case "OutOfStock":
                        for (int i = 0; i < gifts.Count; i++)
                        {
                            if (gifts[i] == gift)
                            {
                                gifts[i] = "None";
                            }
                        }
                        break;
                    case "Required":
                        int index = int.Parse(elements[2]);

                        if (index >= 0 && index <= gifts.Count - 1)
                        {
                            gifts[index] = gift;
                        }
                        break;
                    case "JustInCase":
                        gifts[gifts.Count - 1] = gift;
                        break;
                }

                line = Console.ReadLine();
            }

            foreach (var item in gifts)
            {
                if (item != "None")
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
