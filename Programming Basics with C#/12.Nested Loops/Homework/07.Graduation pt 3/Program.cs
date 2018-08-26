using System;

namespace _07.Graduation_pt_3
{
    class Program
    {
        static string currentName;
        static void Main()
        {
            var name = Console.ReadLine();
            currentName = name;
            while (name != "END")
            {
                var grade = Console.ReadLine();
                var isSuccess = IsSuccess(grade);
                if (isSuccess)
                {
                    var average = ReadWhileSuccess(grade);
                    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
                    name = currentName;
                }
            }
        }

        private static double ReadWhileSuccess(string grade)
        {
            var average = 0.0;
            var counter = 0;
            var numberFall = 0;
            var classOut = 0;
            while (true)
            {
                var parseSucces = ParseSuccess(grade);
                if (parseSucces)
                {
                    var parseGrade = double.Parse(grade);
                    
                    if (LargerThan4(parseGrade))
                    {
                        average += parseGrade;
                        counter++;
                    }
                    else
                    {
                        numberFall++;
                    }

                    if (numberFall > 1)
                    {
                        Console.WriteLine($"{currentName} has been excluded at {classOut} grade");
                        Environment.Exit(0);// break program
                    }
                }
                else
                {
                    currentName = grade;
                    break;
                }
                classOut++;
                grade = Console.ReadLine();
            }
            return average / counter;
        }
        private static bool IsSuccess(string grade)
        {
           return ParseSuccess(grade);
        }
        private static bool ParseSuccess(string grade)
        {
            try
            {
                var readGrade = Convert.ToDouble(grade);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private static bool LargerThan4(double parseGrade)
        {
            return parseGrade >= 4;
        }
    }
}
