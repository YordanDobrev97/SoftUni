﻿using System;

namespace _08.Guess_Password
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
