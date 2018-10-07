using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            PrintHello();
            int x,y;
            GetValues(out x, out y);

            Console.WriteLine(x);
            Console.WriteLine(y);

        }
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        public static void GetValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = int.Parse(Console.ReadLine());
        }
    }
}
