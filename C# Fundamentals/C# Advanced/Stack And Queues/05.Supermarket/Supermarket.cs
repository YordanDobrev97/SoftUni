using System;
using System.Collections.Generic;

namespace _05.Supermarket
{
    public class Supermarket
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            Queue<string> names = new Queue<string>();
            while (name != "End")
            {
                if (name == "Paid")
                {
                    PrintNames(names);
                }
                else
                {
                    names.Enqueue(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }

        private static void PrintNames(Queue<string> names)
        {
            while (names.Count > 0)
            {
                Console.WriteLine(names.Dequeue());
            }
        }
    }
}
