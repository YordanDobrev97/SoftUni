
using System.Collections.Generic;

public class Teacher:Person, IName
{
    private string name;

    public Teacher(string name)
    {
        this.Name = name;
    }

    public List<Discipline> Disciplines { get; set; }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value != null)
            {
                this.name = value;
            }
        }
    }
}

