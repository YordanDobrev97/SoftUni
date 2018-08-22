using System;

namespace _02.Graduation
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            int classNumber = 1;
            int finalyClass = 12;

            double sum = 0;
            int numberFall = 0;
            bool isSuccessClass = true;
            while (classNumber <=finalyClass)
            {
                double grade = double.Parse(Console.ReadLine());


                if (grade >= 4)
                {
                    sum += grade;
                }
                else
                {
                    numberFall++;
                }

                if (numberFall > 1)
                {
                    isSuccessClass = false;
                    break;
                }

                classNumber++;
            }

            if (isSuccessClass)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {classNumber - 1} grade");
            }
        }
    }
}
