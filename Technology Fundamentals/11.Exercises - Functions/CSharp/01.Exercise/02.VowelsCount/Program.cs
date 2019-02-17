using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            int countVowels = GetVowelsCount(line);
            Console.WriteLine(countVowels);

        }
        public static int GetVowelsCount(string line)
        {
            //Pesho
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                string currentSymbol = line[i].ToString().ToLower();

                if (currentSymbol == "a" 
                    || currentSymbol == "e" 
                    || currentSymbol == "o" 
                    || currentSymbol == "u"
                    || currentSymbol == "i")
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
