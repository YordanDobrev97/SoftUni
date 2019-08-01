using System;
using System.Text;

namespace _02.Deciphering
{
    class Program
    {
        static void Main()
        {
            string firstString = Console.ReadLine();
            string[] secondString = Console.ReadLine().Split();

            StringBuilder newString = new StringBuilder();

            for (int i = 0; i < firstString.Length; i++)
            {
                newString.Append((char)(firstString[i] - 3));
            }

            string foundString = secondString[0];
            string replacment = secondString[1];

            newString = newString.Replace(foundString, replacment);
            Console.WriteLine(newString);
        }
    }
}
