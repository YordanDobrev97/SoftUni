
public abstract class Father : Family, IPersonalData
{
    private string name;

    void IPersonalData.Name(string name)
    {
        this.name = name;
    }
}
