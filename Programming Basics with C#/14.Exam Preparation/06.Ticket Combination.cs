using System;
class Program
{
    static void Main()
    {
        int combination =int.Parse(Console.ReadLine());

        int currentNumberCombination = 0;
        for (char first = 'A'; first <='L'; first++)
        {
            for (char second = 'f'; second >='a'; second--)
            {
                for (char third = 'A'; third <='C'; third++)
                {
                    for (int fourth = 1; fourth <=10; fourth++)
                    {
                        for (int fifth = 10; fifth >=1; fifth--)
                        {
                            if (first % 2 == 0)
                            {
                                currentNumberCombination++;
                            }
                            if (currentNumberCombination == combination)
                            {
                                Console.WriteLine($"Ticket combination: {first}{second}{third}{fourth}{fifth}");
                                Console.WriteLine($"Prize: {first + second + third + fourth + fifth} lv.");
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
