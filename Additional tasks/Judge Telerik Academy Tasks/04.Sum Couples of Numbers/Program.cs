using System;
using System.Linq;

namespace _04.Sum_Couples_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers; i++)
            {
                int[] couples = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int sum = 0;
                for (int s = 0; s < couples.Length; s++)
                {
                    sum += couples[s];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
