using System;

class Program
{
    static void Main()
    {
        char firstCharacter = char.Parse(Console.ReadLine());
        char secondCharacter = char.Parse(Console.ReadLine());
        char thirdCharacter = char.Parse(Console.ReadLine());

        string concatCharacter = $"{firstCharacter}{secondCharacter}{thirdCharacter}";
        Console.WriteLine(concatCharacter);
    }
}

