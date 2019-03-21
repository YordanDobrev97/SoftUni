using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            List<int> listNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            listNumbers = listNumbers.OrderByDescending(n => n).ToList();

            var firstMaxElements = listNumbers.Take(3).ToList();

            Console.WriteLine(string.Join(" ", firstMaxElements));
        }
    }
}
