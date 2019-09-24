using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    public class PeriodicTable
    {
        public static void Main()
        {
            int countLines = int.Parse(Console.ReadLine());

            HashSet<string> chemicalElements = new HashSet<string>();
            for (int i = 0; i < countLines; i++)
            {
                string[] elements = Console.ReadLine().Split();

                foreach (var item in elements)
                {
                    chemicalElements.Add(item);
                }
            }

            foreach (var item in chemicalElements.OrderBy(x => x))
            {
                Console.Write($"{item} ");
            };

            Console.WriteLine();
        }
    }
}
