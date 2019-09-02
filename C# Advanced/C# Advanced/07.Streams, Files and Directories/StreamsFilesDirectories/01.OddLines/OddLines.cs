using System;
using System.IO;

namespace _01.OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            using (var reader= new StreamReader(@"Resources\01.Odd Lines\Input.txt"))
            {
                string line;
                int index = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (index % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    index++;
                }
            }
        }
    }
}
