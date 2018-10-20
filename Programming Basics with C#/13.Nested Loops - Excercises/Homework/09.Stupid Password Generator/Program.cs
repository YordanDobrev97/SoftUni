using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        for (int first = 1; first <=firstNumber; first++)
        {
            for (int second = 1; second <=firstNumber; second++)
            {
                for (char third = 'a'; third <'a' + secondNumber; third++)
                {
                    for (char fourth = 'a'; fourth < 'a' + secondNumber; fourth++)
                    {
                        for (int fifth = 1; fifth <=firstNumber; fifth++)
                        {
                            if (fifth > second && fifth > first)
                            {
                                Console.Write($"{first}{second}{third}{fourth}{fifth} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

