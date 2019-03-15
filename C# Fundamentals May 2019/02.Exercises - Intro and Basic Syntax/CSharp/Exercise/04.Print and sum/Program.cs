﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            List<int> range = new List<int>();

            for (int i = startNumber; i <=endNumber; i++)
            {
                sum += i;
                range.Add(i);
            }

            
            Console.WriteLine(string.Join(" ", range));
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
