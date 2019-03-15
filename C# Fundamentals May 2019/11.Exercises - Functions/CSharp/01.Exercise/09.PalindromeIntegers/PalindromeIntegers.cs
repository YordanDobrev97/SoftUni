using System;

namespace _09.PalindromeIntegers
{
    public class PalindromeIntegers
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "END")
            {
                char firstDigit = line[0];
                char lastDigit = line[line.Length - 1];

                if (firstDigit == lastDigit)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                line = Console.ReadLine();
            }
        }
    }
}
