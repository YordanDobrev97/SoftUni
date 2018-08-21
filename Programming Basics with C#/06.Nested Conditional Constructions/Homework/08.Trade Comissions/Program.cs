using System;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main()
        {
            string city = Console.ReadLine().ToLower();
            double salary = double.Parse(Console.ReadLine());

            double comission = 0;
            if (city == "sofia")
            {
                if (salary >= 0 && salary <= 500)
                {
                    comission = 0.05;
                }
                else if(salary > 500 && salary <= 1000)
                {
                    comission = 0.07;
                }
                else if(salary > 1000 && salary <= 10000)
                {
                    comission = 0.08;
                }
                else
                {
                    comission = 0.12;
                }
            }
            else if(city == "varna")
            {
                if (salary >= 0 && salary <= 500)
                {
                    comission = 0.045;
                }
                else if (salary > 500 && salary <= 1000)
                {
                    comission = 0.075;
                }
                else if (salary > 1000 && salary <= 10000)
                {
                    comission = 0.10;
                }
                else
                {
                    comission = 0.13;
                }
            }
            else if(city == "plovdiv")
            {
                if (salary >= 0 && salary <= 500)
                {
                    comission = 0.055;
                }
                else if (salary > 500 && salary <= 1000)
                {
                    comission = 0.08;
                }
                else if (salary > 1000 && salary <= 10000)
                {
                    comission = 0.12;
                }
                else
                {
                    comission = 0.145;
                }
            }
            if (comission == 0 || salary < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"{comission * salary:f2}");
            }
        }
    }
}
