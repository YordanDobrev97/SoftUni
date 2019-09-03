using System;
using System.IO;

namespace _02.LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                var writer = new StreamWriter("Output.txt");
                int counter = 1;

                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine($"{counter}.{line}");
                    line = reader.ReadLine();
                    counter++;
                }

                writer.Close();
            }
        }
    }
}
