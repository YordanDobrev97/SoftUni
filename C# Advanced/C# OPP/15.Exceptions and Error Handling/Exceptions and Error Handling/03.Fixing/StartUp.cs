using System;

namespace _03.Fixing
{
    public class StartUp
    {
        public static void Main()
        {
            string[] weekends = new string[5];
            weekends[0] = "Sunday";
            weekends[1] = "Monday";
            weekends[2] = "Tuesday";
            weekends[3] = "Wednesday";
            weekends[4] = "Thursday";

            for (int i = 0; i <=5; i++)
            {
                try
                {
                    Console.WriteLine(weekends[i]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("There is no such day");
                }
            }
        }
    }
}
