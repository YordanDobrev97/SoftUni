using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Print")
                {
                    break;
                }

                string[] elements = line.Split(";");
                string command = elements[0];
                string condition = elements[1];

                Func<string, string, bool> startWithFilter =
                    (collection, startWith) => collection.StartsWith(startWith);

                Func<string, string, bool> endWithFiler =
                    (collection, endWith) => collection.EndsWith(endWith);

                Func<string, int, bool> lengthFilter =
                    (collection, length) => collection.Length == length;

                Func<string, string, bool> containsFilter =
                    (collection, containsStr) => collection.Contains(containsStr);

                string param = elements[2];
                if (condition == "Starts with")
                {
                    Filter(condition, param, startWithFilter, names);
                }
                else if (condition == "Ends with")
                {
                    Filter(condition, param, endWithFiler, names);
                }
                else if (condition == "Length")
                {
                    //Filter(condition, param, lengthFilter, names);
                }
                else if (condition == "Contains")
                {
                    Filter(condition, param, startWithFilter, names);
                }

            }
        }

        private static void Filter<T>(T condition, T param, Func<T, T, bool> func, List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                //if (func(names[i], param))
                //{
                //    names.RemoveAt(i);
                //}
            }
        }
    }
}
