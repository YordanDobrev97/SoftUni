using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern
{
    internal class Engine : IEngine
    {
        private ICommandInterpreter commandInterpeter;

        public Engine(ICommandInterpreter command)
        {
            this.commandInterpeter = command;
        }

        public void Run()
        {
            while (true)
            {
                string line = Console.ReadLine();

                string result = commandInterpeter.Read(line);
                Console.WriteLine(result);
            }
        }
    }
}