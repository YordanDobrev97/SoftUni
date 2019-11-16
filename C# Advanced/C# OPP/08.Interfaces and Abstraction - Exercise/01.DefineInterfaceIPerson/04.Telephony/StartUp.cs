using System;
using System.Collections.Generic;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            CommandExecutor executor = new CommandExecutor();
            executor.Execute();
        }
    }
}
