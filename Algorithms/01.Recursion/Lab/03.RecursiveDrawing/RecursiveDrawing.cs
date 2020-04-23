using System;

namespace Drawing
{
    public class RecursiveDrawing
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Drawing(n);
        }

        private static void Drawing(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));
            Drawing(n - 1);
            Console.WriteLine(new string('#', n));
        }
    }
}
