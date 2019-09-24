using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            int countNames = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < countNames; i++)
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
