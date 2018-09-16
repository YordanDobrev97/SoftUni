using System;

namespace _06.Sum_Seconds
{
    class Program
    {
        static void Main()
        {
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());

            int seconds = s1 + s2 + s3;
            int zeros = 0;
            string f = "".PadLeft(zeros, '0');

            if (seconds >= 0 && seconds <= 59)
            {
                if (seconds < 9)
                {
                    Console.WriteLine($"0:0{seconds}");
                }
                else
                {
                    Console.WriteLine($"0:{seconds}");
                }
                
            }
            else if (seconds >= 60 && seconds <= 119)
            {
                zeros = seconds - 60 > 9 ? 0 : 1;
                f = "".PadLeft(zeros, '0');
                Console.WriteLine($"1:{f}{seconds - 60}");
            }
            else if (seconds >= 120 && seconds <= 179)
            {
                zeros = (seconds - 120) > 9 ? 0 : 1;
                f = "".PadLeft(zeros, '0');
                Console.WriteLine($"2:{f}{seconds - 120}");
            }            
        }
    }
}
