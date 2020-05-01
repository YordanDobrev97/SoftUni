using System;
using System.Linq;

namespace _01.BubbleSort
{
    public class StartUp
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int i = 0;
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                while (i < nums.Length - 1)
                {
                    int currentValue = nums[i];
                    int nextValue = nums[i + 1];

                    if (currentValue > nextValue)
                    {
                        isSorted = false;
                        nums[i] = nextValue;
                        nums[i + 1] = currentValue;
                    }
                    i++;
                }
                i = 0;

            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
