using System;
using System.Linq;
using System.Text;

namespace _04.ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
