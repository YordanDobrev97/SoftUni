using SUS.MvcFramework;
using System;
using System.Threading.Tasks;

namespace Musaca
{
    public class Program
    {
        public static async Task Main()
        {
            await Host.CreateHostAsync(new Startup());
        }
    }
}
