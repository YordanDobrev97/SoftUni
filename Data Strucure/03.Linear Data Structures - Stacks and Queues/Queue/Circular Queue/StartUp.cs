using System;
namespace Circular_Queue
{
    class StartUp
    {
        static void Main()
        {
            Queue<int> nums = new Queue<int>();
            for (int i = 1; i <=100; i++)
            {
                nums.Enqueue(i);
            }

            int dequeue = nums.Dequeue();
            Console.WriteLine(dequeue);
            int peek = nums.Peek();
            Console.WriteLine(peek);
        }
    }
}
