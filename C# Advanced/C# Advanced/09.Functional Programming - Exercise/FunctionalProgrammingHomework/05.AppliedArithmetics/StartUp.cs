using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                if (line == "add")
                {
                    Action<int[]> add = collection =>
                    {
                        for (int i = 0; i < collection.Length; i++)
                        {
                            collection[i]++;
                        }
                    };
                    add(numbers);
                }
                else if (line == "subtract")
                {
                    Action<int[]> subtract = collection =>
                    {
                        for (int i = 0; i < collection.Length; i++)
                        {
                            collection[i]--;
                        }
                    };
                    subtract(numbers);
                }
                else if (line == "multiply")
                {
                    Action<int[]> multiply = collection =>
                    {
                        for (int i = 0; i < collection.Length; i++)
                        {
                            collection[i] *= 2;
                        }
                    };
                    multiply(numbers);
                }
                else if (line == "print")
                {
                    Action<int[]> print = collection =>
                    {
                        Console.WriteLine(string.Join(" ", collection));
                    };
                    print(numbers);
                }
            }
        }
    }
}
