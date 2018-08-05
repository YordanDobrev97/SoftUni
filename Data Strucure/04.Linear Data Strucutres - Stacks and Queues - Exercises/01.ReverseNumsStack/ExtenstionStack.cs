using System;
using System.Collections.Generic;
namespace _01.ReverseNumsStack
{
    public static class ExtenstionStack
    {
        public static void ToStack<T>(this IEnumerable<T> collection)
        {
            Stack<T> nums = new Stack<T>();
            foreach (var item in collection)
            {
                nums.Push(item);
            }
            if (nums.Count == 0)
            {
                Console.WriteLine("(empty)");
                return;
            }
            Join(nums);
        }
        private static void Join<T>(Stack<T> nums)
        {
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
