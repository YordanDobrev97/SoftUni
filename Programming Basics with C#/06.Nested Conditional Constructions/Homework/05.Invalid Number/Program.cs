﻿using System;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (!(number >= 100 && number <= 200) && number != 0)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
