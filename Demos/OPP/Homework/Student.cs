
public class Student : Person, IName
{
    private string name;

    public Student(string name)
    {
        this.Name = name;
    }

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

