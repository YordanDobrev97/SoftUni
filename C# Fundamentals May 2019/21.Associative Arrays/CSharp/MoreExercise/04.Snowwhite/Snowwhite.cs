using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Draft
    {
        public Draft()
        {
            this.Names = new List<string>();
        }

        public int Physics { get; set; }

        public List<string> Names { get; set; }
    }
    
    class Snowwhite
    {
        static void Main()
        {
            string line = Console.ReadLine();

            Dictionary<string, Draft> drafts = new Dictionary<string, Draft>();
            while (line != "Once upon a time")
            {
                string[] items = line.Split(" <:> ");
                string name = items[0];
                string color = items[1];
                int physic = int.Parse(items[2]);

                if (!drafts.ContainsKey(color))
                {
                    drafts.Add(color, new Draft());
                }

                if (!drafts[color].Names.Contains(name))
                {
                    drafts[color].Names.Add(name);
                    drafts[color].Physics = physic;
                }
                else
                {
                    if (drafts[color].Physics < physic)
                    {
                        drafts[color].Physics = physic;
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var item in drafts.OrderByDescending(x => x.Value.Physics)
                .ThenByDescending(x => x.Value.Names.Count))
            {
                foreach (var name in item.Value.Names)
                {
                    Console.WriteLine($"({item.Key}) {name} <-> {item.Value.Physics}");
                }
            }
        }
    }
}
