using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.IsleManRace
{
    class Program
    {
        static void SolutionWithRegex()
        {
            var patternRaceName = @"([#$%*&])(\w+)\1";
            var patternGeohashcodeLength = @"\=(\d+)";
            var patternEncryptedGeohashCode = @"!!(.*)";

            bool foundGeohashCode = false;
            string geohashCodeResult = string.Empty;
            int lengthWithIncreasing = 0;
            string nameRacer = string.Empty;

            while (true)
            {
                string line = Console.ReadLine();
                Match matchName = Regex.Match(line, patternRaceName);
                Match matchGeohashCode = Regex.Match(line, patternGeohashcodeLength);
                Match matchEncryptedGeohashCode = Regex.Match(line, patternEncryptedGeohashCode);

                if (matchName.Success && matchGeohashCode.Success && matchEncryptedGeohashCode.Success)
                {
                    int length = int.Parse(matchGeohashCode.Groups[1].Value);
                    string engryptGeohashCode = matchEncryptedGeohashCode.Groups[1].Value;

                    if (length == engryptGeohashCode.Length)
                    {
                        nameRacer = matchName.Groups[2].Value;
                        geohashCodeResult = engryptGeohashCode;
                        foundGeohashCode = true;
                        lengthWithIncreasing = length;
                        break;
                    }
                }

                if (!foundGeohashCode)
                {
                    Console.WriteLine("Nothing found!");
                }
            }

            string result = string.Empty;

            for (int i = 0; i < geohashCodeResult.Length; i++)
            {
                char newSymbol = (char)(geohashCodeResult[i] + lengthWithIncreasing);
                result += newSymbol;
            }

            Console.WriteLine($"Coordinates found! {nameRacer} -> {result}");
        }

        static void SolutionWitoutRegex()
        {
            string name = string.Empty;
            string message = string.Empty;
            int length = 0;

            while (true)
            {
                string line = Console.ReadLine();

                char firstSymbol = line[0];

                bool isValid = false;
                char[] validSymbols = new char[] { '#', '$', '%', '*', '&' };

                if (validSymbols.Contains(firstSymbol))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                string nameRacer = string.Empty;
                int startIndex = line.IndexOf(firstSymbol) + 1;

                while (!validSymbols.Contains(line[startIndex]))
                {
                    if (char.IsLetter(line[startIndex]))
                    {
                        nameRacer += line[startIndex];
                        startIndex++;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }

                if (line[startIndex] != firstSymbol)
                {
                    isValid = false;
                }

                int indexGeohashCode = line.IndexOf('=');

                if (startIndex + 1 != indexGeohashCode)
                {
                    isValid = false;
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                string lengthOfGeohashCodeStr = string.Empty;

                while (line[indexGeohashCode + 1] != '!')
                {
                    bool isNumber = int.TryParse(line[indexGeohashCode + 1].ToString(), out int num);

                    if (!isNumber)
                    {
                        isValid = false;
                        break;
                    }
                    lengthOfGeohashCodeStr += line[indexGeohashCode + 1];
                    indexGeohashCode++;
                }

                if (!isValid)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                int valueGeohashCode = int.Parse(lengthOfGeohashCodeStr);

                int enctryptGeohashCodeIndex = line.IndexOf('!') + 2;

                string encrtyptMessage = line.Substring(enctryptGeohashCodeIndex);

                if (valueGeohashCode != encrtyptMessage.Length)
                {
                    isValid = false;
                }

                if (!isValid)
                {
                    Console.WriteLine("Nothing found!");
                }
                else
                {
                    name = nameRacer;
                    message = encrtyptMessage;
                    length = valueGeohashCode;
                    break;
                }
            }

            string result = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                result += (char)(message[i] + length);
            }

            Console.WriteLine($"Coordinates found! {name} -> {result}");
        }

        static void Main()
        {
            SolutionWithRegex();
            //SolutionWitoutRegex();
        }
    }
}
