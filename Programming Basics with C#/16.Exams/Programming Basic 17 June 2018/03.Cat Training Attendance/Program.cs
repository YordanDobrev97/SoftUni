using System;

namespace _03.Cat_Training_Attendance
{
    class Program
    {
        static void Main()
        {
            int startLecture = int.Parse(Console.ReadLine());
            int timeOfAttendance = int.Parse(Console.ReadLine());
            int minutesOfAttendance = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double bonusScore = 0;
            int endLecture = startLecture + 1;

            if (timeOfAttendance < startLecture && timeOfAttendance <= (startLecture - 1))
            {
                bonusScore += 1.5;
            }
            else if(timeOfAttendance == startLecture && minutesOfAttendance <= 30)
            {
                bonusScore += 1.0;
            }
            else if((timeOfAttendance == startLecture && minutesOfAttendance > 30) || timeOfAttendance < (startLecture + 4))
            {
                bonusScore += 0.5;
            }

            switch (dayOfWeek)
            {
                case "Monday":
                case "Wednesday":
                case "Friday":
                    bonusScore += 0.6;
                    break;
                case "Tuesday":
                case "Thursday":
                case "Saturday":
                    bonusScore += 0.8;
                    break;
                case "Sunday":
                    bonusScore += 2;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{bonusScore:f2}");
        }
    }
}
