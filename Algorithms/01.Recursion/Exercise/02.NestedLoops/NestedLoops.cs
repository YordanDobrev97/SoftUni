using System;

namespace _02.NestedLoops
{
    public class NestedLoops
    {
        public static void Main()
        {
            int n = 2;
            int counter = 1;
            NestedLoopRecursion(n);


        }

        public static void NestedLoopRecursion(int n)
        {
            if (n <= 0)
            {
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Iteration {i} in loop {n - 1} from center");
                NestedLoopRecursion(n - 1);
            }
        }
    }
}
