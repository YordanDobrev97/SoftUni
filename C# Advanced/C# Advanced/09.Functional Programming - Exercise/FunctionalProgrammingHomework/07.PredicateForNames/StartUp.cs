using System;

namespace _07.PredicateForNames
{
    public class StartUp
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Predicate<string> lengthNames = x => x.Length <= length;
            Action<string[]> print = collection =>
            {
                foreach (var item in collection)
                {
                    if (lengthNames(item))
                    {
                        Console.WriteLine(item);
                    }
                }
            };

            print(names);


        }
    }
}
