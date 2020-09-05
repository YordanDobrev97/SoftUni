using MortalEngines.IO.Contracts;
using System;

namespace MortalEngines.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
