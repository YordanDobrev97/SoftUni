using System;
using System.Collections.Generic;
using System.Linq;

namespace TowerОfHanoi
{
    public class StartUp
    {
        private static int step = 1;
        private static Stack<int> source;
        private static Stack<int> middle;
        private static Stack<int> destination;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var values = Enumerable.Range(1, n);

            source = new Stack<int>(values.Reverse());
            middle = new Stack<int>();
            destination = new Stack<int>();

            Print();
            MoveDisks(n, source, middle, destination);
        }

        private static void MoveDisks(int bottom, Stack<int> source, Stack<int> middle, Stack<int> destination)
        {
            if (bottom == 1)
            {
                var lastDisk = source.Pop();
                destination.Push(lastDisk);

                Console.WriteLine($"Step #{step}: Moved disk");
                Print();
                step++;
            }
            else
            {
                MoveDisks(bottom - 1, source, destination, middle);
                var currentDisk = source.Pop();
                destination.Push(currentDisk);
                Console.WriteLine($"Step #{step++}: Moved disk");
                Print();
                MoveDisks(bottom - 1, middle, source, destination);
            }
        }

        private static void Print()
        {
            Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", middle.Reverse()));
            Console.WriteLine();
        }
    }
}
