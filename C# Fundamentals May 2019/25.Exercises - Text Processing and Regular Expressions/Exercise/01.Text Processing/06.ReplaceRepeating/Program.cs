using System;
using System.Text;

namespace _06.ReplaceRepeating
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            char prev = ' ';

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == prev)
                {
                    continue;
                }
                else
                {
                    result.Append(line[i]);
                    prev = line[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
