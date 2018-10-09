using System;
using System.Linq;

namespace _05.Login
{
    class Program
    {
        static void Main()
        {
            string userName = Console.ReadLine();
            var password = userName.Reverse().ToList();

            string reversedPassword = string.Join("", password);

            string passwordInput = Console.ReadLine();
            int count = 1;
            bool hasCorrectlyPassword = false;
            while (true)
            {
                if (passwordInput == reversedPassword)
                {
                    hasCorrectlyPassword = true;
                    break;
                }

                if (count >=4)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                count++;
                passwordInput = Console.ReadLine();
            }

            if (!hasCorrectlyPassword)
            {
                Console.WriteLine($"User {userName} blocked!");
            }
            else
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
