using CommandPattern.Core.Contracts;
using System;
using System.Reflection;
using System.Linq;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] elements = args.Split();

            string command = elements[0] + "Command";
            var type = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == command);

            if (type == null)
            {
                throw new ArgumentException("type is missing!");
            }

            var instanceCommand = (ICommand)Activator.CreateInstance(type);

            string result = instanceCommand.Execute(elements);
            return result;
        }
    }
}