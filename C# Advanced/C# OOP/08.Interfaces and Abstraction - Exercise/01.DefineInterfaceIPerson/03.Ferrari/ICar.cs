using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface ICar
    {
        string Model { get; }

        string DriverName { get; set; }
           
        string Brake();

        string Gas();
    }
}
