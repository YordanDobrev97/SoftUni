using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    public class StartUp
    {
        public static void Main()
        {
            using (var reader = new StreamReader("text.txt"))
            {
                var counterRow = 0;
                using (var writer = new StreamWriter("output.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        if (counterRow % 2 == 0)
                        {
                            string[] symbols = { "-", ",", ".", "!", "?" };

                            for (int i = 0; i < symbols.Length; i++)
                            {
                                line = line.Replace(symbols[i][0], '@');
                            }

                            var reversed = string.Join(" ", line.Split().Reverse());

                            writer.WriteLine(reversed, true);
                        }

                        counterRow++;
                    }
                }
            }
        }
    }
}
