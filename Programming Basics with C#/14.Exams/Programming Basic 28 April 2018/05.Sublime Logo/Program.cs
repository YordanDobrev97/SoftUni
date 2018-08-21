using System;

namespace _05.Sublime_Logo
{
    class Program
    {
        static void Main()
        {
            int sizeLogo = int.Parse(Console.ReadLine());

            int space = sizeLogo * 2 - 2;
            int stars = 2;
            for (int i = 0; i < sizeLogo; i++)
            {
                Console.WriteLine(new string(' ', space) + new string('*', stars));
                space -= 2;
                stars += 2;
            }

            stars = sizeLogo * 2 - 4;
            for (int i = 0; i < 3; i++)
            {
                if (i % 2 == 1)
                {
                    stars -= 2;
                }
                else
                {
                    stars += 2;
                }
                Console.WriteLine(new string('*', stars) + " ");
            }
            Console.WriteLine(new string('*', sizeLogo * 2));

            space = 2;
            stars = sizeLogo * 2 - 2;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(new string(' ', space) + new string('*', stars));
                if (i % 2 == 0)
                {
                    space += 2;
                    stars -= 2;
                }
                else
                {
                    space -= 2;
                    stars = sizeLogo * 2 - 2;
                }
            }

            Console.WriteLine(new string('*', sizeLogo * 2));

            stars = sizeLogo * 2 - 2;
            space = 1;
            for (int i = 0; i < sizeLogo - 1; i++)
            {
                Console.WriteLine(new string('*', stars) + new string(' ', space));
                stars -= 2;

            }
        }
    }
}
