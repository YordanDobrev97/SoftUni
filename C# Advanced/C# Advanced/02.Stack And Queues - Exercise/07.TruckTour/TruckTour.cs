using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    public class TruckTour
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<Dictionary<int, int>> pumps = new Queue<Dictionary<int, int>>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                var currentPump = new Dictionary<int, int>();
                currentPump.Add(input[0], input[1]);
                pumps.Enqueue(currentPump);
            }

            int index = 0;
            while (true)
            {
                int fuel = 0;
                foreach (var pump in pumps)
                {
                    int amount = pump.Keys.ToList()[0];
                    int distance = pump.Values.ToList()[0];

                    fuel += amount - distance;

                    if (fuel < 0)
                    {
                        pumps.Enqueue(pumps.Dequeue());
                        index++;
                        break;
                    }
                }

                if (fuel > 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
