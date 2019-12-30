using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.EasterGifts
{
    class Program
    {
        static void Main()
        {
            List<string> gifts = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();
            while (command != "No Money")
            {
                var args = command.Split();

                switch (args[0])
                {
                    case "OutOfStock":
                        for (int i = 0; i < gifts.Count; i++)
                        {
                            if (gifts[i] == args[1])
                            {
                                gifts[i] = "None";
                            }
                        }

                        break;
                    case "Required":
                        int index = int.Parse(args[2]);
                        var gift = args[1];

                        if (index >= 0 && index <=gifts.Count - 1)
                        {
                            gifts[index] = gift;
                        }
                        break;
                    case "JustInCase":
                        var newValue = args[1];
                        gifts[gifts.Count - 1] = newValue;
                        break;
                }


                command = Console.ReadLine();
            }

            foreach (var gift in gifts)
            {
                if (gift != "None")
                {
                    Console.Write($"{gift} ");
                }
            }

            Console.WriteLine();
        }
    }
}
