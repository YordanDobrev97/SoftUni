using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine().Split(" ").ToList();

            string firstString = secondInput[0];
            string secondString = secondInput[1];

            string decryptedInput = "";

            Regex regex = new Regex(@"^[d-z{}\|#]+$");

            var match = regex.Match(firstInput);

            for (int i = 0; i < match.Length; i++)
            {
                char currentChar = firstInput[i];
                decryptedInput += ((char)(currentChar - 3));
            }

            if (decryptedInput.Contains(firstString))
            {
                decryptedInput = decryptedInput.Replace(firstString, secondString);

                Console.WriteLine(decryptedInput);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}