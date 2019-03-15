using System;

class Program
{
    static void Main()
    {
        char character = char.Parse(Console.ReadLine());

        if (char.IsUpper(character))
        {
            Console.WriteLine("upper-case");
        }
        else
        {
            Console.WriteLine("lower-case");
        }
    }
}

