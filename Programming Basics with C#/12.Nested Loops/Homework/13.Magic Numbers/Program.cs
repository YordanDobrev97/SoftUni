using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int first = 1; first <=9; first++)
        {
            for (int second = 1; second <=9; second++)
            {
                for (int third = 1; third <=9; third++)
                {
                    for (int fourth = 1; fourth <=9; fourth++)
                    {
                        for (int fifth = 1; fifth <=9; fifth++)
                        {
                            for (int sixth = 1; sixth <=9; sixth++)
                            {
                                int product = first * second * third * fourth * fifth * sixth;
                                if (product== number)
                                {
                                    Console.Write($"{first}{second}{third}{fourth}{fifth}{sixth} ");
                                }
                            }
                        }
                    }
                }
            }            
        }
        Console.WriteLine();
    }
}

