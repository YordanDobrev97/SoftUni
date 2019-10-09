using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    public class StartUp
    {
        public static void Main()
        {
            var currentDirectory = Environment.CurrentDirectory;
            var path = $"{currentDirectory}/copyMe.png";
            var output = $"{currentDirectory}/resultImage.png";

            int defaultValue = 4096;
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var writerBinary = new BinaryWriter(new FileStream(output, FileMode.Create));
                while (true)
                {
                    var buffer = new byte[defaultValue];
                    int lengthFileRead = fileStream.Read(buffer, 0, buffer.Length);

                    if (lengthFileRead <= 0)
                    {
                        break;
                    }

                    writerBinary.Write(buffer, 0,lengthFileRead);

                    if (lengthFileRead < defaultValue)
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}
