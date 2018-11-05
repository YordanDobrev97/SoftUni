using System;

class Program
{
    static int firstSpecialNumber = 5;
    static int secondSpecialNumber = 7;
    static int thirdSpecialNumber = 11;
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <=number; i++)
        {
            if (isSpecialNumber(i))
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
        }
    }
    static bool isSpecialNumber(int number)
    {
        string numberAsString = number.ToString();
        int sum = 0;

        for (int i = 0; i < numberAsString.Length; i++)
        {
            sum += numberAsString[i] - '0';
        }

        if (sum == firstSpecialNumber 
            || sum == secondSpecialNumber 
            || sum == thirdSpecialNumber)
        {
            return true;
        }

        return false;
    }
}

