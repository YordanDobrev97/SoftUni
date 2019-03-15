using System;

namespace _10.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeatString(str, count);
            Console.WriteLine(result);
        }

        private static string RepeatString(string str, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
