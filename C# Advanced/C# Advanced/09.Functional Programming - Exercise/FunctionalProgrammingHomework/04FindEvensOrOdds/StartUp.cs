using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FindEvensOrOdds
{
    public class StartUp
    {
        public static void Main()
        {
            int[] rangeInput = Console.ReadLine().Split(" ", 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = rangeInput[0];
            int end = rangeInput[1];

            List<int> numbersRange = new List<int>();

            for (int i = start; i <=end; i++)
            {
                numbersRange.Add(i);
            }

            string conditionInput = Console.ReadLine();

            Predicate<int> condition;
            if (conditionInput == "odd")
            {
                condition = x => x % 2 == 1;
            }
            else
            {
                condition = x => x % 2 == 0;
            }


            Action<List<int>> print = collection =>
            {
                Console.WriteLine(string.Join(" ", collection));
            };

            print(numbersRange.Where(x => condition(x)).ToList());
        }
    }
}
