using System;
class Program
{
    static void Main()
    {
        int maxGoals = int.MinValue;
        string winner = string.Empty;
        bool isHetrick = false;
        while (true)
        {
            string namePlayer = Console.ReadLine();
            if (namePlayer == "END")
            {
                break;
            }
            int countGoals = int.Parse(Console.ReadLine());

            if (countGoals >= 3)
            {
                isHetrick = true;
            }
            if (countGoals > maxGoals)
            {
                maxGoals = countGoals;
                winner = namePlayer;
            }

            if (countGoals >= 10)
            {
                break;
            }

           
        }
        Console.WriteLine($"{winner} is the best player!");

        if (isHetrick)
        {
            Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
        }
        else
        {
            Console.WriteLine($"He has scored {maxGoals} goals.");
        }
    }
}

