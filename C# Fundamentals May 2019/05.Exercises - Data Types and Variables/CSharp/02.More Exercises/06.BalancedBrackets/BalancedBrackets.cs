using System;
public class BalancedBrackets
{
    public static void Main()
    {
        int numberLines = int.Parse(Console.ReadLine());

        int openBracketsCount = 0;
        int closeBracketsCount = 0;

        for (int i = 0; i < numberLines; i++)
        {
            string line = Console.ReadLine();

            if (line.Contains("("))
            {
                openBracketsCount++;
            }
            else if (line.Contains(")"))
            {
                closeBracketsCount++;
            }
        }

        if (openBracketsCount == closeBracketsCount)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}