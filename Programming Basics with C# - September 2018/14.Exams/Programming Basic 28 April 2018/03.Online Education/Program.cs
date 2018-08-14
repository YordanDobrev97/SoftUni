using System;

namespace _03.Online_Education
{
    class Program
    {
        static void Main()
        {
            string formOfEducationForBeforehand = Console.ReadLine();
            int numberOfRecorderBeforehand = int.Parse(Console.ReadLine());

            string formOfEducationForNormal = Console.ReadLine();
            int numberOfRecorderNormal = int.Parse(Console.ReadLine());

            string formOfEducationForLater = Console.ReadLine();
            int numberOfRecorderLater = int.Parse(Console.ReadLine());

            int maxCapacityInHall = 600;

            int totalOnlineStudents = 0;
            int totalOnsiteStudents = 0;

            if (formOfEducationForBeforehand == "onsite")
            {
                if (numberOfRecorderBeforehand <= maxCapacityInHall)
                {
                    totalOnsiteStudents += numberOfRecorderBeforehand;
                }
                else
                {
                    if (totalOnsiteStudents == maxCapacityInHall)
                    {
                        totalOnlineStudents += numberOfRecorderBeforehand;
                    }
                    else
                    {
                        int remainder = numberOfRecorderBeforehand - maxCapacityInHall;
                        totalOnlineStudents += remainder;
                        totalOnsiteStudents += maxCapacityInHall;
                    }
                }
            }
            else
            {
                totalOnlineStudents += numberOfRecorderBeforehand;
            }

            if (formOfEducationForNormal == "onsite")
            {
                if (totalOnsiteStudents + numberOfRecorderNormal <= maxCapacityInHall)
                {
                    totalOnsiteStudents += numberOfRecorderNormal;
                }
                else
                {
                    if (totalOnsiteStudents == maxCapacityInHall)
                    {
                        totalOnlineStudents += numberOfRecorderNormal;
                    }
                    else
                    {
                        int remainderOnline = Math.Abs(maxCapacityInHall - (numberOfRecorderNormal + totalOnsiteStudents));
                        totalOnlineStudents += remainderOnline;

                        int onsite = numberOfRecorderNormal - remainderOnline;
                        totalOnsiteStudents += onsite;
                    }
                }
            }
            else
            {
                totalOnlineStudents += numberOfRecorderNormal;
            }

            if (formOfEducationForLater == "onsite")
            {
                if (totalOnsiteStudents + numberOfRecorderLater <= maxCapacityInHall)
                {
                    totalOnsiteStudents += numberOfRecorderLater;
                }
                else
                {
                    if (totalOnsiteStudents == maxCapacityInHall)
                    {
                        totalOnlineStudents += numberOfRecorderLater;
                    }
                    else
                    {
                        int remainder = maxCapacityInHall - (numberOfRecorderLater + totalOnsiteStudents);
                        totalOnlineStudents += remainder;

                        int remainderOnsite = numberOfRecorderLater - remainder;
                        totalOnsiteStudents += remainderOnsite;
                    }
                }
            }
            else
            {
                totalOnlineStudents += numberOfRecorderLater;
            }
            
            Console.WriteLine($"Online students: {totalOnlineStudents}");
            Console.WriteLine($"Onsite students: {totalOnsiteStudents}");
            Console.WriteLine($"Total students: {totalOnlineStudents + totalOnsiteStudents}");
        }
    }
}
