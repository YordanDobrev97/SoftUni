﻿using System;

namespace _02.Numbers_Ending_in_7
{
    class Program
    {
        static void Main()
        {
            for (int i = 7; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
