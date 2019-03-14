using System;

namespace _05.MergeSort
{
    class MergeSort
    {
        static void Main()
        {
            int[] nums = { 24, 4, 34, 56, 0, 11, 33, 2 };
            Merge<int> merge = new Merge<int>();

            merge.Sort(nums);

            
        }

    }
}
