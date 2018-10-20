using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double validNameCount = 0;
        double invalidCount = 0;
        double totalCountName = 0;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Statistic")
            {
                break;
            }
            else
            {
                totalCountName++;
                //check if name is valid
                bool hasNeedModify = false;
                bool hasValidName = true;
                for (int i = 0; i < input.Length; i++)
                {
                    char symbol = input[i];
                    if (!char.IsLetter(symbol))
                    {
                        hasValidName = false;
                        break;
                    }
                    if (i == 0 && char.IsLower(symbol))
                    {
                        hasNeedModify = true;
                    }
                    else if (i > 0 && !(char.IsLower(symbol)))
                    {
                        hasNeedModify = true;
                    }
                }
                if (hasValidName)
                {
                    validNameCount++;
                    if (!hasNeedModify)
                    {
                        Console.WriteLine(input);
                    }
                    else
                    {
                        //modify
                        var lowerCase = input.Skip(1)
                            .Take(input.Length - 1)
                            .ToArray();

                        string remainder = string.Join("", lowerCase).ToLower();
                        string firstLetter = input[0].ToString().ToUpper();
                        Console.WriteLine($"{firstLetter}{remainder}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid name!");
                    invalidCount++;
                }
            }
        }
        
        Console.WriteLine("Valid names are {0:f2}% from {1} names.", validNameCount / totalCountName * 100.00, totalCountName);
        Console.WriteLine("Invalid names are {0:f2}% from {1} names.", invalidCount / totalCountName * 100.00, totalCountName);
    }
}

