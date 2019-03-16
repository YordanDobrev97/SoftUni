using System;
using System.Collections.Generic;

public class Song
{
    public Song(string type, string name, string time)
    {
        this.Type = type;
        this.Name = name;
        this.Time = time;
    }

    public string Type { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

