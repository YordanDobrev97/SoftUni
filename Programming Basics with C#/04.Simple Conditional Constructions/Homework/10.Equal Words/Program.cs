using System;

namespace _10.Equal_Words
{
    class Program
    {
        static void Main()
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
