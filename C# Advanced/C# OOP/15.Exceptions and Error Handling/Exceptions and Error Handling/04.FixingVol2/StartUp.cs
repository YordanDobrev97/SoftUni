using System;

namespace _04.FixingVol2
{
    public class StartUp
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                byte result = Convert.ToByte(num1 * num2);
                Console.WriteLine($"{num1} x {num2} = {result}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too big numbers");
            }
        }
    }
}
