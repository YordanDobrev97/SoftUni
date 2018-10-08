using System;

namespace _09.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int num = 1;

            int count = 1;
            while (count <= number)
            {
                if (num % 2 == 1)
                {
                    sum += num;
                    Console.WriteLine(num);
                    num+=2;
                }
                count++;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
