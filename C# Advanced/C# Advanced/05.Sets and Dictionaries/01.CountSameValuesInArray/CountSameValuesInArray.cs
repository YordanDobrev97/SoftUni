using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var values = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            var countValues = new Dictionary<double, int>();

            foreach (var value in values)
            {
                if (!countValues.ContainsKey(value))
                {
                    countValues.Add(value, 0);
                }
                countValues[value]++;
            }

            foreach (var kvpValues in countValues)
            {
                var key = kvpValues.Key;
                var value = kvpValues.Value;

                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
