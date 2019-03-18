using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.Substring
{
    public class Substring
    {
        public static void Main()
        {
            string foundString = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();

            int lengthFound = foundString.Length;
            
            for (int i = 0; i < input.Length; i++)
            {
                int index = input.IndexOf(foundString);

                if (index != -1)
                {
                    input = input.Remove(index, foundString.Length);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(input);
        }
    }
}
