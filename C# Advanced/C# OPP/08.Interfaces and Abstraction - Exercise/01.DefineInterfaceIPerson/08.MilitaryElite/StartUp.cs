using MilitaryElite.Core;
using MilitaryElite.Models;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        public static void Main()
        {
            CommandExecutor commandExecutor = new CommandExecutor();
            commandExecutor.Execute();
        }
    }
}
