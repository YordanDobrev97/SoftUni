using System;

namespace _04.Own_Bussiness
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int m = width * length * height;
            while (command != "Done")
            {
                int numberComputer = int.Parse(command);
                m -= numberComputer;

                if (m < 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (m < 0)
            {
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(m));
            }
            else
            {
                Console.WriteLine("{0} Cubic meters left.", m);
            }
        }
    }
}
