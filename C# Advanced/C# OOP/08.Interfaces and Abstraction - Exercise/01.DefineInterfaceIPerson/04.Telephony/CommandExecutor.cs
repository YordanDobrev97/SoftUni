using System;

namespace Telephony
{
    public class CommandExecutor
    {
        public void Execute()
        {
            string[] phones = Console.ReadLine().Split();
            string[] address = Console.ReadLine().Split();

            ICallable smartphone = new Smartphone();
            IBrowseable browseable = new Smartphone();

            foreach (var phone in phones)
            {
                string result = smartphone.Call(phone);
                Console.WriteLine(result);
            }

            foreach (var item in address)
            {
                string result = browseable.Browse(item);
                Console.WriteLine(result);
            }
        }
    }
}
