using System;

namespace _01.ActionPrint
{
    public class StartUp
    {
        public static void Main()
        {
            string[] names = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = x => Console.WriteLine(string.Join(Environment.NewLine, x));
            print(names);
        }
    }
}
