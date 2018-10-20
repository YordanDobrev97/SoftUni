using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int first = 1; first <9; first++)
        {
            for (int second = 1; second <9; second++)
            {
                for (int third = 1; third <9; third++)
                {
                    for (int fouth = 1; fouth <9; fouth++)
                    {
                        if (number    % first  == 0 
                            && number % second == 0
                            && number % third  == 0
                            && number % fouth  == 0)
                        {
                            Console.Write($"{first}{second}{third}{fouth} ");
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}

