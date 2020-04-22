using System;

namespace _02.NestedLoops
{
    public class NestedLoops
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int count = 1;
            NestedLoopRecursion(array, count);
        }

        public static void NestedLoopRecursion(int[] array, int count)
        {
            if (count > array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                array[count - 1] = i;
                NestedLoopRecursion(array, count + 1);
            }
        }
    }
}
