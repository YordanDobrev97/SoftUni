using System;

namespace LinkedQueue
{
    class StartUp
    {
        static void Main()
        {
            MyLinkedQueue<int> linkedQueue = new MyLinkedQueue<int>();

            for (int i = 1; i <=10; i++)
            {
                linkedQueue.Enqueue(i);
            }
            Console.WriteLine($"Peek item: {linkedQueue.Peek()}"); // 1

            Console.WriteLine($"Dequeu item: {linkedQueue.Dequeue()}"); // remove 1

            Console.WriteLine($"Peek item: {linkedQueue.Peek()}"); // 2
        }
    }
}
