using System;

namespace _12.Faces_Of_Figures
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                int square = int.Parse(Console.ReadLine());
                Console.WriteLine(square * square);
            }
            else if (figure == "rectangle")
            {
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());

                Console.WriteLine(firstSide * secondSide);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * r *r);
            }
            else
            {
                double length = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine(length * height / 2);
            }
        }
    }
}
