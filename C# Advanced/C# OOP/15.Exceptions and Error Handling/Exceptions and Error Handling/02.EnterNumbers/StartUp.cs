using System;

namespace _02.EnterNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            int maxNumbers = 10;

            int maxNumber = 10;
            int minNumber = 1;

            string standartMessage = "Enter your number: ";
            string messageSuccess = "Enter your next number: ";
            string message = standartMessage;

            for (int i = 0; i < maxNumbers; i++)
            {
                try
                {
                    ReadNumber(minNumber, maxNumber, message);
                    Console.WriteLine("You entered the number successfully!");
                    message = messageSuccess;
                }
                catch (ArgumentException ex)
                {
                    message = standartMessage;
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void ReadNumber(int start, int end, string message)
        {
            Console.Write(message);
            int number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
            {
                throw new ArgumentException($"The number shoubld be int range {start} and {end}");
            }

        }
    }
}
