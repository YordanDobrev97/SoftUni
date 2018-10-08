using System;

namespace _11.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int count = 1;
            bool specialCase = true;
            while (count <= 10 && end <=10)
            {
                Console.WriteLine($"{start} X {end} = {start * end}");
                end++;
                count++;
                specialCase = false;
            }

            if (specialCase)
            {
                Console.WriteLine($"{start} X {end} = {start * end}");
            }
        }
    }
}
