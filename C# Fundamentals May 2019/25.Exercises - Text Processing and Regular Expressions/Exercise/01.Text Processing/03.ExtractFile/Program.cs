using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main()
        {
            string pathFile = Console.ReadLine();

            int indexFile = pathFile.LastIndexOf('\\');

            string filename = pathFile.Substring(indexFile + 1);
            int extensionIndex = filename.IndexOf('.');

            string extension = filename.Substring(extensionIndex + 1);
            filename = filename.Remove(extensionIndex);

            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
