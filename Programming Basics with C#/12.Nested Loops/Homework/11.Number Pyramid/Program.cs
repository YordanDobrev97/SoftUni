using System;

namespace _11.Number_Pyramid
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(counter + " ");
                    counter++;
                    if (counter > n)
                    {
                        break;
                    }
                }
                if (counter > n)
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
