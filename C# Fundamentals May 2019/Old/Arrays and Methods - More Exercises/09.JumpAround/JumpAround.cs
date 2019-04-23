using System;
using System.Linq;

namespace _09.JumpAround
{
    class JumpAround
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            int index = 0;

            while (true)
            {
                int value = array[index];
                sum += value;

                if (IsNotRange(array, index, value))
                {
                    break;
                }

                if (index + value > array.Length - 1)
                {
                    index -= value;
                }
                else
                {
                    index += value;
                }
            }

            Console.WriteLine(sum);
        }

        private static bool IsNotRange(int[] array, int index, int value)
        {
            return (index + value > array.Length - 1) && (index - value < 0);
        }
    }
}
