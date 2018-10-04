using System;

namespace Demo
{
    class Program
    {
        static void ChangeValue(int number, ref int otherNumber)
        {
            number = 100;
            otherNumber = 12345;
        }

        static void Main(string[] args)
        {
            int number = 10;
            int otherNumber = number;

            otherNumber = 20;

            Console.WriteLine("Value of number before: {0}", number);
            Console.WriteLine("Value oth otherNumber before: {0}", otherNumber);

            ChangeValue(number, ref otherNumber);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Value of number after: {0}", number);
            Console.WriteLine("Value oth otherNumber after: {0}", otherNumber);           
        }
    }
}
