using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var currentDirectory = Environment.CurrentDirectory;
        var fileData = File.ReadAllText(currentDirectory + @"\text.txt");

        var allLines = fileData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

        int counter = 1;
        using (var writer = new StreamWriter("output.txt"))
        {
            foreach (var item in allLines)
            {
                var lengthOfLetter = GetLenghLetter(item);
                var lengthOfPunctuationMarks = GetLengthPunctuationMarks(item);
                writer.WriteLine($"Line {counter} {item}({lengthOfLetter})({lengthOfPunctuationMarks})", true);
                counter++;
            }
        }
    }

    public static int GetLenghLetter(string input)
    {
        var letters = GetOnlyLetters(input);

        var countLetters = letters.Where(x => x != ' ').ToList();
        return countLetters.Count;
    }

    private static int GetLengthPunctuationMarks(string item)
    {
        int punctuationMarksCount = 0;

        char[] punctuationMarks = new char[]{'-', '\'', ',', '.', '!', '?' };

        foreach (var symbol in item)
        {
            if (punctuationMarks.Contains(symbol))
            {
                punctuationMarksCount++;
            }
        }

        return punctuationMarksCount;
    }

    private static List<char> GetOnlyLetters(string item)
    {
        var letters = item.Where(x => x != '.' && x != ',' && x != '!' && x != '-'
        && x != '?' && x != '\n' && x != '\r' && x != '\'').ToList();

        return letters;
    }
}

