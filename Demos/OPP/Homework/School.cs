
public class School:IName
{
    private string name;

    public School(string name)
    {
        this.Name = name;
    }

    public Student Student { get; set; }
    public Teacher Teacher { get; set; }


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
