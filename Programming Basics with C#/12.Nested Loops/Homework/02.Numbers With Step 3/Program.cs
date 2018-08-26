using System;

namespace _02.Numbers_With_Step_3
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
