using System;
using System.Collections.Generic;

namespace _07.TheVLogger
{
    public class Vlogger
    {
        public Vlogger(int followers, int following)
        {
            this.Followers = followers;
            this.Following = following;
            this.Vloggers = new List<string>();
        }

        public int Followers { get; set; }

        public int Following { get; set; }

        public List<string> Vloggers { get; set; }

        public void AddVlogger(string currentVlogger)
        {
            this.Vloggers.Add(currentVlogger);
        }
    }

    public class TheVLogger
    {
        public static void Main()
        {
            int totalVloggers = 0;

            var vloggersFollowers = new Dictionary<string, Vlogger>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] elements = null;

                if (input.Contains("joined"))
                {
                    elements = input.Split(" joined ");
                    string vloggerName = elements[0];
                    totalVloggers++;
                    if (!vloggersFollowers.ContainsKey(vloggerName))
                    {
                        vloggersFollowers.Add(vloggerName, new Vlogger(0, 0));
                    }
                }
                else
                {
                    elements = input.Split(" followed ");
                    string firstVloggerName = elements[0];
                    string secondVloggerName = elements[1];

                    if (vloggersFollowers.ContainsKey(firstVloggerName) 
                        && vloggersFollowers.ContainsKey(secondVloggerName))
                    {
                        var vlogger = vloggersFollowers[firstVloggerName];
                        var vloggerFollowing = vlogger.Vloggers;

                        if (!vloggerFollowing.Contains(secondVloggerName) &&
                            firstVloggerName != secondVloggerName)
                        {
                            vlogger.Following++;
                            vloggerFollowing.Add(secondVloggerName);
                        }
                    }
                }
                
            }
        }
    }
}
