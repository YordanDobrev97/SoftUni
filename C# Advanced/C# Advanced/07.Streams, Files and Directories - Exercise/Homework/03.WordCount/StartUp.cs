using System;
using System.IO;

public class StartUp
{
    public static void Main()
    {
        var currentDirectory = Environment.CurrentDirectory;
        var fileData = File.ReadAllText(currentDirectory + @"\words.txt");

        var words = fileData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

        using (var writer = new StreamWriter("actualResult.txt"))
        {
            foreach (var word in words)
            {
                int counter = 0;
                using (var reader = new StreamReader("text.txt"))
                {
                    var line = reader.ReadLine().ToLower();

                    if (line.Contains(word.ToLower()))
                    {
                        counter++;
                    }
                }
            }
        }
    }
}

