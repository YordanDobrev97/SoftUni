using System;
using System.Linq;

namespace _03.Max_Sum_of_K_elements
{
    class Program
    {
        private const int DEFAULT_VALUE = 0;
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] elements = new long[n];

            for (long i = 0; i < n; i++)
            {
                long element = long.Parse(Console.ReadLine());
                elements[i] = element;
            }
            Array.Sort(elements);

            long sum = 0;
            int lastIndex = elements.Length - 1;
            for (int i = 0; i < k; i++)
            {
                sum += elements[lastIndex];
                lastIndex--;
            }
           
            Console.WriteLine(sum);
        }
    }
}
