using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            string value = args[1];
            return $"Hello {value}";
        }
    }
}
