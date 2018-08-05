using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SequenceQueue
{
    class SequenceQueue
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int s1 = n;
            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(s1);

            List<int> result = new List<int>();
            for (int i = 1; i <=50; i++)
            {
                int first = sequence.Peek() + 1;
                sequence.Enqueue(first);

                int second = (2 * sequence.Peek()) + 1;
                sequence.Enqueue(second);

                int third = first + 1;
                sequence.Enqueue(third);

                sequence.Dequeue();
                result.Add(first);
                result.Add(second);
                result.Add(third);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
