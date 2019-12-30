using System;

namespace _01.ValidUsername
{
    class ValidUsername
    {
        static bool IsLengthBetweeen3And16(string input)
        {
            return input.Length >= 3 && input.Length <= 16;
        }

        static bool ContainsLetters(string input)
        {
            bool hasLetters = true;
            foreach (var item in input)
            {
                if (!char.IsLetter(item))
                {
                    hasLetters = false;
                    break;
                }
            }
            return hasLetters;
        }

        static bool ContainsNumbers(string input)
        {
            bool hasNumbers = false;

            foreach (var item in input)
            {
                if (char.IsNumber(item))
                {
                    hasNumbers = true;
                    break;
                }
            }

            return hasNumbers;
        }

        static bool SpecialSymbols(string input)
        {
            bool hasSpecialSymbols = false;

            foreach (var item in input)
            {
                if (item == '-' || item == '_')
                {
                    hasSpecialSymbols = true;
                    break;
                }
            }
            return hasSpecialSymbols;
        }

        static bool NotContainsRedundantSymbols(string input)
        {
            bool hasRedundantSymbols = false;

            foreach (var item in input)
            {
                if (char.IsLetterOrDigit(item))
                {
                    hasRedundantSymbols = true;
                    break;
                }
            }
            return hasRedundantSymbols;
        }

        static void Main()
        {
            string[] items = Console.ReadLine().Split(", ");

            foreach (var item in items)
            {
                bool validLength = IsLengthBetweeen3And16(item);
                bool validSymbols = ContainsLetters(item) || ContainsNumbers(item) || SpecialSymbols(item);
                bool notRedundantSymbols = NotContainsRedundantSymbols(item);
                if (validLength && validSymbols && notRedundantSymbols)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
