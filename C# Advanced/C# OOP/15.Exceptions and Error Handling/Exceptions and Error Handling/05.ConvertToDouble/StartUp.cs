using System;
using System.Numerics;

namespace _05.ConvertToDouble
{
    public class StartUp
    {
        public static void Main()
        {
            string maxValueDouble = "1.29e325";

            try
            {
                var convertDouble = Convert.ToDouble(maxValueDouble);
                Console.WriteLine(convertDouble);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too big value");
            }
        }
    }
}
