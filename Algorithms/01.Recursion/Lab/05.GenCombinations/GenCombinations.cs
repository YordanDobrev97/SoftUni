using System;

namespace _05.GenCombinations
{
    class GenCombinations
    {
        static int getIndexNums = 0;
        static int oldValueGetIndexNums = 0;
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int k = 2;
            int[] data = new int[k];
            Combination(nums, k, 0,0, data);
        }

        static void Combination(int[] nums, int k, int index,int start, int[] data)
        {
            if (index == k)
            {
                PrintResult(data);
            }
            else
            {
                for (int i = start; i < k; i++)
                {
                    data[index] = nums[i];
                    Combination(nums, k, index + 1, i + 1, data);
                    
                }
            }
        }

        private static void PrintResult(int[] data)
        {
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
