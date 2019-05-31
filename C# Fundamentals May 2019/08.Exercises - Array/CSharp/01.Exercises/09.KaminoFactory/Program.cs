using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            List<string> sequences = new List<string>();

            while (line != "Clone them!")
            {
                sequences.Add(line);
            }

            for (int i = 0; i < sequences.Count; i++)
            {
                string previosValue = "Not have value";//default value

                string[] sequence = sequences[i].Split("!");

            }
            
        }
    }
}
