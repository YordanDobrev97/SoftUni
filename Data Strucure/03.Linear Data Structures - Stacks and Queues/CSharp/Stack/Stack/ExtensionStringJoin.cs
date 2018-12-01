using System;
using System.Collections.Generic;
using System.Linq;
namespace StackExtensionJoin
{
    public static class ExtensionStringJoin
    {
        public static void StrJoin(this IEnumerable<int> items)
        {
            Console.WriteLine(string.Join(",", items));
        }
    }
}
