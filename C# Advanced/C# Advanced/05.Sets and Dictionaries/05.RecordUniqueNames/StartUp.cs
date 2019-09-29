﻿using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    public class StartUp
    {
        public static void Main()
        {
            HashSet<string> names = new HashSet<string>();

            int numberOfNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNames; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
