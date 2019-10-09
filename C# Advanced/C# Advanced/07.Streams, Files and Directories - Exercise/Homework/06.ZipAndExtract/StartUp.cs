using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    public class StartUp
    {
        public static void Main()
        {
            ZipFile.CreateFromDirectory("./", "../../../resultImage.zip", 
                CompressionLevel.Fastest, true);

            ZipFile.ExtractToDirectory("../../../resultImage.zip", "../../../extract");
        }
    }
}
