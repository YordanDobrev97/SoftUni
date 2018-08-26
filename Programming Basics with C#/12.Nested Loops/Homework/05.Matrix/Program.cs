using System;

namespace _05.Matrix
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());


            for (int i1 = a; i1 <= b; i1++)
            {
                for (int i2 = a; i2 <= b; i2++)
                {
                    for (int i3 = c; i3 <=d; i3++)
                    {
                        for (int i4 = c; i4 <=d; i4++)
                        {
                            if (i1 != i2 && i3 != i4)
                            {
                                if (i1 + i4 == i2 + i3)
                                {
                                    Console.WriteLine($"{i1}{i2}");
                                    Console.WriteLine($"{i3}{i4}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
