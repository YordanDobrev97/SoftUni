
public class Child : Family, IPersonalData
{
    private string name;

    public Child(string name)
    {
        
    }

    void IPersonalData.Name(string name)
    {
        this.name = name;
    }
}

