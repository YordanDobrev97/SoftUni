using System;
using System.Linq;

namespace _10.Reverse_Number
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string reverse = new string(Enumerable.Range(1, input.Length).Select(i => input[input.Length - i]).ToArray());
            Console.WriteLine(reverse);
        }
    }
}
