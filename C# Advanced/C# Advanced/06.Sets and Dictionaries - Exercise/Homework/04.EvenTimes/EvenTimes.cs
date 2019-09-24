using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    public class EvenTimes
    {
        public static void Main()
        {
            int countLines = int.Parse(Console.ReadLine());

            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < countLines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine(number);
                    break;
                }

                numbers.Add(number);
            }
        }
    }
}
