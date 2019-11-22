using System;

namespace _01.SquareRoot
{
    public class StartUp
    {
        static string InvalidMessage = "Invalid number";
       
        public static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                int squre = SqureNumber(number);
                Console.WriteLine($"Square of number is : {squre}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(InvalidMessage);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        public static int SqureNumber(int number)
        {
            return number * number;
        }
    }
}
