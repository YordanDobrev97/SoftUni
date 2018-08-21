using System;

namespace _01.Еxcellent_Evaluation
{
    class Program
    {
        static void Main()
        {
            double evaluation = double.Parse(Console.ReadLine());

            if (evaluation >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
