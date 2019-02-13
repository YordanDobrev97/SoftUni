using System;

namespace _04.PasswordValidator
{
    class PasswordValidator
    {
        static void Main()
        {
            string password = Console.ReadLine();

            ValidPassword(password);
            
        }
        static void ValidPassword(string password)
        {
            bool isValidPassword = true;
            if (!ValidLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
                isValidPassword = false;
            }

            if (!ContaisLettersDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValidPassword = false;
            }

            if (!PasswordHasLeastTwoDigit(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValidPassword = false;
            }

            if (isValidPassword)
            {
                Console.WriteLine("Password is valid");
            }


        }

        private static bool PasswordHasLeastTwoDigit(string password)
        {
            bool hasTwoDigits = false;
            int count = 0;
            int maxDigit = 2;
            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }

                if (count == maxDigit)
                {
                    hasTwoDigits = true;
                    break;
                }
            }
            return hasTwoDigits;
        }

        private static bool ContaisLettersDigits(string password)
        {
            foreach (var item in password)
            {
                if (!(char.IsDigit(item) || char.IsLetter(item)))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidLength(string password)
        {
            return (password.Length >= 6 && password.Length <= 10);
        }
    }
}
