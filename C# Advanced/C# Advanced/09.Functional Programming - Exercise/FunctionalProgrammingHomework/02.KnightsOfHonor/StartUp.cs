using System;

namespace _02.KnightsOfHonor
{
    public class StartUp
    {
        public static void Main()
        {
            string[] names = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = x => Console.WriteLine($"Sir {string.Join(Environment.NewLine + "Sir ",  x)}");
            print(names);
        }
    }
}
