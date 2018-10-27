using System;
class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int first = k; first <=8; first++)
        {
            for (int second = 9; second >= l; second--)
            {
                for (int third = m; third <=8; third++)
                {
                    for (int fourth = 9; fourth >=n; fourth--)
                    {
                        bool isValidFirstCondition = (first % 2 == 0) 
                            && (second % 2 == 1);

                        bool isValidSecondCondition = (third % 2 == 0) 
                            && (fourth % 2 == 1);

                        if (isValidFirstCondition && isValidSecondCondition)
                        {
                            if (first == third && second == fourth)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else 
                            {
                                counter++;
                                Console.WriteLine($"{first}{second} - {third}{fourth}");
                            }
                            if (counter == 6)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
