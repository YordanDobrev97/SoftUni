using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    public class StartUp
    {
        public static void Main()
        {
            int rangeNumber = int.Parse(Console.ReadLine());
            int[] sequence = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> rangeNumbers = new List<int>();
            for (int i = 1; i <=rangeNumber; i++)
            {
                rangeNumbers.Add(i);
            }

            Func<int, int, bool> divisible = (x, y) => x % y == 0;

            Action<List<int>, int[]> iterate = (list, array) =>
            {
                foreach (var rangeList in list)
                {
                    bool disible = true;
                    foreach (var item in array)
                    {
                        if (!divisible(rangeList, item))
                        {
                            disible = false;
                        }
                    }

                    if (disible)
                    {
                        Console.Write($"{rangeList} ");
                    }
                }
            };
            iterate(rangeNumbers, sequence);
            
        }
    }
}
