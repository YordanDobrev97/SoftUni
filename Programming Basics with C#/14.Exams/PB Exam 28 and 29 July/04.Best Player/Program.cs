using System;

namespace _04.Best_Player
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();

            string nameWinner = string.Empty;
            int numberGolas = 0;
            bool isTatTrick = false;
            while (command != "END")
            {
                string namePlayer = command;
                int goals = int.Parse(Console.ReadLine());

                if (goals > numberGolas)
                {
                    numberGolas = goals;
                    nameWinner = namePlayer;
                }
                if (goals >= 3)
                {
                    isTatTrick = true;
                }
                if (goals >= 10)
                {
                    break;
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine("{0} is the best player!", nameWinner);

            if (isTatTrick)
            {
                Console.WriteLine("He has scored {0} goals and made a hat-trick !!!", numberGolas);
            }
            else
            {
                Console.WriteLine("He has scored {0} goals.", numberGolas);
            }
        }
    }
}
