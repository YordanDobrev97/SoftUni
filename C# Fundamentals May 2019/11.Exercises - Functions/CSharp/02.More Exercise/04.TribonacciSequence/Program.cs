using System;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            long[] sequence = new long[number];
            FindTribonacciSequence(sequence);

            PrintSequence(sequence);
        }

        static void PrintSequence(long[] sequence)
        {
            Console.WriteLine(string.Join(" ", sequence));
        }

        static void FindTribonacciSequence(long[] sequence)
        {
            
            long first = 1;
            long second = 1;
            long third = 2;

            sequence[0] = first;
            sequence[1] = second;
            sequence[2] = third;

            for (int i = 3; i < sequence.Length; i++)
            {
                long thirdPositionNumber = sequence[i - 1];
                long secondPositionNumber = sequence[i - 2];
                long firstPositionNumber = sequence[i - 3];

                long sum = thirdPositionNumber + secondPositionNumber + firstPositionNumber;
                sequence[i] = sum;
            }
        }
    }
}
