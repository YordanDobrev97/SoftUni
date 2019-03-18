using System;
using System.Text;

namespace _02.RepeatStrings
{
    public class RepeatStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in elements)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    stringBuilder.Append(item);
                }
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
