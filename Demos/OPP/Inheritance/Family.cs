using System.Collections.Generic;

public class Family
{
    public string Name { get; set; }

    public Mother Mother { get; set; }

    public Father Father { get; set; }

    public List<Child> Children { get; set; }
}