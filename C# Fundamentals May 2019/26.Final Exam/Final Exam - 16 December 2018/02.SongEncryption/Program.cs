using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.SongEncryption
{
    class Program
    {
        static char GetSymbol(char symbol, int lengthArtist, int code)
        {
            if (symbol + lengthArtist <=code)
            {
                return (char)(symbol + lengthArtist);
            }

            return ((char)((symbol + lengthArtist) - 26));
        }

        static string GetEncryp(string input, int lengthArtist)
        {
            string result = string.Empty;
            foreach (var item in input)
            {
                if (item == ' ' || item == '\'')
                {
                    result += item;
                }
                else
                {
                    int code = 122;
                    if (char.IsUpper(item))
                    {
                        code = 90;
                    }
                    char symbol = GetSymbol(item, lengthArtist, code);
                    result += symbol;
                }
            }

            return result;
        }

        static void Main()
        {
            string line = Console.ReadLine();
            var patternArtist = new Regex(@"^[A-Z][a-z\' ]+");
            var patternSong = new Regex(@"^[A-Z ]+$");

            while (line != "end")
            {
                string[] elements = line.Split(":");
                string artist = elements[0];
                string song = elements[1];

                Match matchArtist = patternArtist.Match(artist);
                Match matchSong = patternSong.Match(song);

                if ((matchArtist.Length == artist.Length) && matchSong.Success)
                {
                    StringBuilder result = new StringBuilder();
                    int lengthArtist = artist.Length;

                    result.Append(GetEncryp(artist, lengthArtist));

                    result.Append("@");

                    result.Append(GetEncryp(song, lengthArtist));

                    Console.WriteLine($"Successful encryption: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                line = Console.ReadLine();
            }
        }
    }
}