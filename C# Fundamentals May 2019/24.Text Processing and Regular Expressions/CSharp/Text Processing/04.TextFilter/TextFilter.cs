using System;

namespace _04.TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ");

            string inputElemens = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string bannedWord = bannedWords[i];

                int index = inputElemens.IndexOf(bannedWord);
                while (index != -1)
                {
                    inputElemens = inputElemens.Replace(bannedWord, new string('*', bannedWord.Length));

                    index = inputElemens.IndexOf(bannedWord);
                }
            }

            Console.WriteLine(inputElemens);
        }
    }
}
