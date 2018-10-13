using System;

namespace _03.Salary
{
    class Program
    {
        static void Main()
        {
            int fineFacebook = 150;
            int fineInstagram = 100;
            int fineReddit = 50;

            int numberTabsBrowser = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            
            for (int i = 0; i < numberTabsBrowser; i++)
            {
                if (salary <= 0)
                {
                    break;
                }

                string websiteName = Console.ReadLine();

                if (websiteName == "Facebook")
                {
                    salary -= fineFacebook;
                }
                else if (websiteName == "Instagram")
                {
                    salary -= fineInstagram;
                }
                else if (websiteName == "Reddit")
                {
                    salary -= fineReddit;
                }
            }

            if (salary == 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
