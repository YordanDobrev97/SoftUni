using System;

namespace _15.Matrix_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            int counter = 1;
            for (int i = 1; i <=sizeMatrix; i++)
            {
                counter = i;
                for (int col = 1; col <=sizeMatrix; col++)
                {
                    Console.Write("{0} ", counter);
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}
