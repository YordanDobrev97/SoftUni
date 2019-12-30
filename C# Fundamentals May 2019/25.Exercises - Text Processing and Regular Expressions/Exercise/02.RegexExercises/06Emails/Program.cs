using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Furniture
    {
        static void Main()
        {
            var pattern =
                new Regex(@"\b([a-z]+)(\d+)?(\.|-|_?)([a-z]+)?\@([a-z]+)(\.|-|_?)([a-z]+)?(\.[a-z]+)?([a-z]+)?(\.[a-z]+).*?\b");

            var input = Console.ReadLine();

            var matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}