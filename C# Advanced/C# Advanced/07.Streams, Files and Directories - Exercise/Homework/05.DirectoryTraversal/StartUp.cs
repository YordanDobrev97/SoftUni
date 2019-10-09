using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    public class StartUp
    {
        public static void Main()
        {
            var filesDirectory = new Dictionary<string, Dictionary<string, double>>();

            string[] allFiles = Directory.GetFiles("../../../");
            foreach (var file in allFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;
                string name = fileInfo.Name;
                long length = fileInfo.Length;

                if (filesDirectory.ContainsKey(extension))
                {
                    filesDirectory[extension].Add(name, length);
                }
                else
                {
                    var nestedDictionary = new Dictionary<string, double>();
                    nestedDictionary.Add(name, length);
                    filesDirectory.Add(extension, nestedDictionary);

                }
            }

            filesDirectory = filesDirectory.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, v => v.Value);

            using (var writer = new StreamWriter("../../../output.txt"))
            {
                foreach (var file in filesDirectory)
                {
                    writer.WriteLine(file.Key);

                    foreach (var nested in file.Value)
                    {
                        writer.WriteLine($"--{nested.Key} - {nested.Value}kb");
                    }
                }
            }
        }
    }
}
