﻿
public abstract class Mother : Family, IPersonalData
{
    private string name;

    void IPersonalData.Name(string name)
    {
        this.name = name;
    }
}
